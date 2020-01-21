using LaborStackApp.Model;
using LaborStackApp.Response;
using LaborStackApp.Service;
using LaborStackApp.Service.Inter;
using LaborStackApp.Service.net;
using LaborStackApp.Toolkits;
using log4net;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WorkerType = LaborStackApp.Response.WorkerType;

namespace LaborStackApp.Modal
{
    public partial class MainForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MainForm));
        private readonly Color BorderColor = Color.FromArgb(220, 220, 220);

        private SQLiteConnection db;
        private LoginUser loginUser = new LoginUser();//保存已成功登录用户信息对象
        private List<ProjectInfo> projectList;//保存当前登录成功用户关联项目信息
        private IEnumerable<WorkerListData> workerListData;//存储当前页工人信息列表
        private IEnumerable<ManagerListData> managerListData;//存储当前页管理人员信息列表
        private IEnumerable<TeamData> teamDatas;//存储当前页班组信息列表

        private LaborServiceInterface<LoginUser> laborServiceInterface;

        private string GroupProjectCode = string.Empty;
        private string WorkerProjectCode = string.Empty;
        private string ManagerProjectCode = string.Empty;

        private ProjectInfo WorkerProjectInfo;
        private ProjectInfo TeamProjectInfo;
        private ProjectInfo ManagerProjectInfo;
        private List<WorkerType> workerTypes;
        private List<Nation> nations;

        public MainForm(SQLiteConnection db, List<WorkerType> workerTypes, List<Nation> nations)
        {
            InitializeComponent();
            this.db = db;
            this.workerTypes = workerTypes;
            this.nations = nations;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormClosing += MainForm_FormClosing;

            laborServiceInterface = new LoginUserService(db);
            loginUser = laborServiceInterface.GetSingle(null);
            if (null == loginUser)
                return;

            ProjectsResponseData projectsResponse = new ProjectsResponseData();
            ProjectsResponseService.Response(loginUser, 1, 1000, ref projectsResponse);
            if (null == projectsResponse)
                return;
            if (null == projectsResponse.data)
                return;
            
            projectList = projectsResponse.data;
            ProjectListComboBoxLoadData();

            workers_pageUserControl.OnPageChanged += Workers_pageUserControl_OnPageChanged;
            manager_pageUserControl.OnPageChanged += Manager_pageUserControl_OnPageChanged;

            group_projects_comboBox.SelectedValueChanged += Group_projects_comboBox_SelectedValueChanged;
            workers_projects_comboBox.SelectedValueChanged += Workers_projects_comboBox_SelectedValueChanged;
            manager_comboBox.SelectedValueChanged += Manager_comboBox_SelectedValueChanged;
        }

        private void Manager_pageUserControl_OnPageChanged(object sender, EventArgs e)
        {
            LoadManagersData(manager_comboBox);
        }

        private void Manager_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProjectInfo projectInfo = projectList[comboBox.SelectedIndex];
            ManagerProjectInfo = projectInfo;
            string res = string.Format("当前项目：{0} 项目地址：{1}", projectInfo.projectName, projectInfo.address);
            if (res.Length > 50)
                res = res.Substring(0, 50) + "...";
            sys_status_toolStripStatusLabel.Text = res;
            ManagerProjectCode = comboBox.SelectedValue.ToString();
            log.DebugFormat("ManagerProjectCode = {0}", ManagerProjectCode);
            LoadManagersData(comboBox);
        }

        private void Workers_projects_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProjectInfo projectInfo = projectList[comboBox.SelectedIndex];
            WorkerProjectInfo = projectInfo;
            string res = string.Format("当前项目：{0} 项目地址：{1}", projectInfo.projectName, projectInfo.address);
            if (res.Length > 50)
                res = res.Substring(0, 50) + "...";
            sys_status_toolStripStatusLabel.Text = res;
            WorkerProjectCode = comboBox.SelectedValue.ToString();
            LoadWorkersData(comboBox);
        }

        private void Group_projects_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            ProjectInfo projectInfo = projectList[comboBox.SelectedIndex];
            TeamProjectInfo = projectInfo;
            string res = string.Format("当前项目：{0} 项目地址：{1}", projectInfo.projectName, projectInfo.address);
            if (res.Length > 50)
                res = res.Substring(0, 50) + "...";
            sys_status_toolStripStatusLabel.Text = res;
            GroupProjectCode = comboBox.SelectedValue.ToString();
            LoadTeamGridViewData(group_projects_comboBox);
        }

        private void Workers_pageUserControl_OnPageChanged(object sender, EventArgs e)
        {
            LoadWorkersData(workers_projects_comboBox);
        }

        private void ProjectListComboBoxLoadData()
        {
            if (null == projectList)
                return;
            ComboboxDataLoad(group_projects_comboBox);
            ComboboxDataLoad(workers_projects_comboBox);
            ComboboxDataLoad(manager_comboBox);
        }

        private void ComboboxDataLoad(object sender)
        {
            ComboBox comboBox = sender as ComboBox;
            comboBox.DataSource = projectList;
            comboBox.DisplayMember = "projectName";
            comboBox.ValueMember = "projectCode";
        }

        private void LoadTeamGridViewData(ComboBox comboBox)
        {
            if (string.Empty.Equals(comboBox.SelectedValue.ToString()))
            {
                log.Debug("项目编号为空！");
                return;
            }
            GroupProjectCode = comboBox.SelectedValue.ToString();
            if (!group_backgroundWorker.IsBusy)
                group_backgroundWorker.RunWorkerAsync();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("真的要退出程序吗？", "退出程序", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void group_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Common.BorderDraw(sender, e, BorderColor);
        }

        private void group_search_pictureBox_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(groupname_search_textBox.Text.Trim()))
            {
                Common.ErrAlert("请输入班组名称查询！");
                return;
            }
            LoadTeamGridViewData(group_projects_comboBox);
        }

        private void worker_add_button_Click(object sender, EventArgs e)
        {
            if (null == WorkerProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            WorkerInfoForm workerInfoForm = new WorkerInfoForm(db, null, WorkerProjectInfo, loginUser, workerTypes, nations);
            if (workerInfoForm.ShowDialog() == DialogResult.OK)
                LoadWorkersData(workers_projects_comboBox);
        }

        private void worker_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Common.BorderDraw(sender, e, BorderColor);
        }

        private void LoadWorkersData(ComboBox comboBox)
        {
            if (string.Empty.Equals(WorkerProjectCode))
                return;
            if (!workerData_backgroundWorker.IsBusy)
                workerData_backgroundWorker.RunWorkerAsync();
        }

        private void LoadManagersData(ComboBox comboBox)
        {
            if (string.Empty.Equals(ManagerProjectCode))
                return;
            if (!manager_backgroundWorker.IsBusy)
                manager_backgroundWorker.RunWorkerAsync();
        }

        private void workers_modify_button_Click(object sender, EventArgs e)
        {
            if (workers_dataGridView.SelectedRows.Count == 0)
            {
                Common.ErrAlert("请选择一行再修改！");
                return;
            }
            WorkerListData worker = workerListData.ToList()[workers_dataGridView.SelectedRows[0].Index];
            if (null == worker)
            {
                Common.ErrAlert("加载选择的工人数据发生错误！");
                return;
            }
            if (null == WorkerProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            WorkerInfoForm workerInfoForm = new WorkerInfoForm(db, worker, WorkerProjectInfo, loginUser, workerTypes, nations);
            if (workerInfoForm.ShowDialog() == DialogResult.OK)
                LoadWorkersData(workers_projects_comboBox);
        }

        private void manager_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Common.BorderDraw(sender, e, BorderColor);
        }

        private void worker_search_pictureBox_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(worker_search_keyword_textBox.Text.Trim()))
            {
                Common.ErrAlert("请输入工人姓名或身份证号查询！");
                return;
            }
            LoadWorkersData(workers_projects_comboBox);
        }

        private void workerData_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if (null == loginUser)
            {
                e.Cancel = true;
                return;
            }

            WorkersResponse workerListResponse = new WorkersResponse();
            WorkerRequestService.Response(loginUser, WorkerProjectCode, workers_pageUserControl, ref workerListResponse);
            if (null == workerListResponse)
                return;
            if (null == workerListResponse.data)
                return;
            if (!IsHandleCreated)
                return;
            Invoke(new Action(() =>
            {
                WorkerListEvent(workerListResponse);
            }));
        }

        private void WorkerListEvent(WorkersResponse workerListResponse)
        {
            workers_dataGridView.DataBindings.Clear();
            workerListData = workerListResponse.data.workerList;
            if (workerListData.Count() <= 0)
            {
                Common.ErrAlert("当前选择项目下暂无人员数据！");
                return;
            }
            string workerSearchKeyword = worker_search_keyword_textBox.Text.Trim();
            if (!string.Empty.Equals(workerSearchKeyword))
            {
                workerListData = from w in workerListData
                                 where (w.idCardNumber.Contains(workerSearchKeyword) || w.workerName.Contains(workerSearchKeyword))
                                 select w;
            }
            var tplist = from tp in workerListData
                         select new
                         {
                             身份证号 = tp.idCardNumber,
                             姓名 = tp.workerName,
                             性别 = Common.GetGenderFromIDCardNumber(tp.idCardNumber),
                             班组 = tp.teamName,
                             工种 = tp.workTypeName,
                             证件照 = Common.ZoomImage(Common.Base64ToImg(tp.idCardPhoto), 40, 40),
                             现场照 = Common.ZoomImage(Common.Base64ToImg(tp.ocvFace), 40, 40)
                         };
            workers_dataGridView.DataSource = tplist.ToList();
            if (string.Empty.Equals(workerSearchKeyword))
                workers_pageUserControl.DrawControl(workerListResponse.data.workerCounts);
            else
                workers_pageUserControl.DrawControl(workerListData.ToList().Count);
        }

        private void group_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if (string.Empty.Equals(GroupProjectCode))
            {
                e.Cancel = true;
                return;
            }

            if (null == loginUser)
            {
                e.Cancel = true;
                return;
            }

            TeamDataGridViewLoad();
        }

        private void TeamDataGridViewLoad()
        {
            try
            {
                TeamDataResponse teamDataResponse = new TeamDataResponse();
                TeamRequestService.Response(loginUser, GroupProjectCode, ref teamDataResponse);
                if (null == teamDataResponse)
                    return;
                if (null == teamDataResponse.data)
                    return;
                if (0 >= teamDataResponse.data.Count)
                    return;
                if (IsHandleCreated)
                {
                    Invoke(new Action(() =>
                    {
                        team_dataGridView.DataBindings.Clear();
                        teamDatas = teamDataResponse.data;
                        if(teamDatas.Count() <= 0)
                        {
                            Common.ErrAlert("当前项目下暂无班组信息！");
                            return;
                        }
                        string teamSearchKeyword = groupname_search_textBox.Text.Trim();
                        if (!string.Empty.Equals(teamSearchKeyword))
                            teamDatas = from w in teamDatas
                                        where (w.teamName.Contains(teamSearchKeyword))
                                             select w;
                        var tplist = from tp in teamDatas
                                     select new
                                     {
                                         班组名称 = tp.teamName,
                                         班组总人数 = tp.count
                                     };
                        team_dataGridView.DataSource = tplist.ToList();
                    }));
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
        }

        private void worker_del_button_Click(object sender, EventArgs e)
        {
            if (workers_dataGridView.SelectedRows.Count == 0)
            {
                Common.ErrAlert("请选择一行再删除！");
                return;
            }
            WorkerListData worker = workerListData.ToList()[workers_dataGridView.SelectedRows[0].Index];
            if (null == worker)
            {
                Common.ErrAlert("加载选择的工人数据发生错误！");
                return;
            }
            if (null == WorkerProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            if (MessageBox.Show(string.Format("真的要删除工人 {0} 吗？", worker.workerName), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            CommonResponseData commonResponseData = new CommonResponseData();
            WorkerRequestService.RequestDelAction(worker, loginUser, ref commonResponseData);
            if (null == commonResponseData)
            {
                Common.ErrAlert("网络或服务异常，请联系管理员！");
                return;
            }
            if (!commonResponseData.success)
            {
                Common.ErrAlert("删除失败！\n" + commonResponseData.message);
                return;
            }
            Common.SuccessAlert("删除成功！");
            LoadWorkersData(workers_projects_comboBox);
        }

        private void team_add_button_Click(object sender, EventArgs e)
        {
            if (null == TeamProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            TeamInfoForm teamInfoForm = new TeamInfoForm(db, TeamProjectInfo, null, loginUser);
            if (teamInfoForm.ShowDialog() == DialogResult.OK)
                TeamDataGridViewLoad();
        }

        private void team_modify_button_Click(object sender, EventArgs e)
        {
            if (null == TeamProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            if (team_dataGridView.SelectedRows.Count == 0)
            {
                Common.ErrAlert("请选择一行再修改！");
                return;
            }
            TeamData teamData = teamDatas.ToList()[team_dataGridView.SelectedRows[0].Index];
            if (null == teamData)
            {
                Common.ErrAlert("加载选择的班组数据发生错误！");
                return;
            }
            TeamInfoForm teamInfoForm = new TeamInfoForm(db, TeamProjectInfo, teamData, loginUser);
            if (teamInfoForm.ShowDialog() == DialogResult.OK)
                TeamDataGridViewLoad();
        }

        private void del_team_button_Click(object sender, EventArgs e)
        {
            if (null == TeamProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            if (team_dataGridView.SelectedRows.Count == 0)
            {
                Common.ErrAlert("请选择一行再修改！");
                return;
            }
            TeamData teamData = teamDatas.ToList()[team_dataGridView.SelectedRows[0].Index];
            if (null == teamData)
            {
                Common.ErrAlert("加载选择的班组数据发生错误！");
                return;
            }
            if (MessageBox.Show(string.Format("真的要删除班组 {0} 吗？", teamData.teamName), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            CommonResponseData commonResponse = new CommonResponseData();
            TeamRequestService.RequestDelAction(teamData, loginUser, ref commonResponse);
            if (null != commonResponse)
            {
                if (commonResponse.success)
                {
                    Common.SuccessAlert("删除操作成功！");
                    TeamDataGridViewLoad();
                }
                else
                    Common.ErrAlert("删除失败！\n" + commonResponse.message);
            }
            else
                Common.ErrAlert("删除操作异常，请检查网络连接或联系管理员！");
        }

        private void manager_add_button_Click(object sender, EventArgs e)
        {
            if (null == ManagerProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            ManagerInfoForm managerInfoForm = new ManagerInfoForm(db, null, ManagerProjectInfo, loginUser, nations);
            if (managerInfoForm.ShowDialog() == DialogResult.OK)
                LoadManagersData(manager_comboBox);
        }

        private void manager_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if (null == loginUser)
            {
                e.Cancel = true;
                return;
            }

            try
            {
                ManagersResponse managers = new ManagersResponse();
                ManagerRequestService.Response(loginUser, ManagerProjectCode, manager_pageUserControl, ref managers);
                if (null == managers)
                    return;
                if (null == managers.data)
                    return;
                if (IsHandleCreated)
                {
                    Invoke(new Action(() =>
                    {
                        manager_dataGridView.DataBindings.Clear();
                        if(managers.data.Count <= 0)
                        {
                            Common.ErrAlert("当前选择项目下暂无管理人员数据！");
                            return;
                        }
                        managerListData = managers.data;
                        string managerSearchKeyword = manager_search_textBox.Text.Trim();
                        if (!string.Empty.Equals(managerSearchKeyword))
                        {
                            managerListData = from w in managerListData
                                              where (w.idCardNumber.Contains(managerSearchKeyword) || w.employeeName.Contains(managerSearchKeyword))
                                             select w;
                        }
                        var tplist = from tp in managerListData
                                     select new
                                     {
                                         身份证号 = tp.idCardNumber,
                                         姓名 = tp.employeeName,
                                         性别 = Common.GetGenderFromIDCardNumber(tp.idCardNumber),
                                         地址 = tp.address,
                                         证件照 = Common.ZoomImage(Common.Base64ToImg(tp.idCardPhoto), 40, 40),
                                         现场照 = Common.ZoomImage(Common.Base64ToImg(tp.ocvFace), 40, 40)
                                     };
                        manager_dataGridView.DataSource = tplist.ToList();
                        if (string.Empty.Equals(managerSearchKeyword))
                            manager_pageUserControl.DrawControl(managers.data.Count);
                        else
                            manager_pageUserControl.DrawControl(managerListData.ToList().Count);
                    }));
                }
                
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void manager_search_pictureBox_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(manager_search_textBox.Text.Trim()))
            {
                Common.ErrAlert("请输入管理人员姓名或身份证号查询！");
                return;
            }
            LoadManagersData(manager_comboBox);
        }

        private void manager_modify_button_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(ManagerProjectCode))
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            if (manager_dataGridView.SelectedRows.Count == 0)
            {
                Common.ErrAlert("请选择一行再修改！");
                return;
            }
            ManagerListData manager = managerListData.ToList()[manager_dataGridView.SelectedRows[0].Index];
            if (null == manager)
            {
                Common.ErrAlert("加载选择的管理人员数据发生错误，请重试！");
                return;
            }
            ManagerInfoForm managerInfoForm = new ManagerInfoForm(db, manager,ManagerProjectInfo,loginUser,nations);
            if (managerInfoForm.ShowDialog() == DialogResult.OK)
                LoadManagersData(manager_comboBox);
        }

        private void manager_del_button_Click(object sender, EventArgs e)
        {
            if (manager_dataGridView.SelectedRows.Count == 0)
            {
                Common.ErrAlert("请选择一行再删除！");
                return;
            }
            ManagerListData manager = managerListData.ToList()[manager_dataGridView.SelectedRows[0].Index];
            if (null == manager)
            {
                Common.ErrAlert("加载选择的管理人员数据发生错误，请重试！");
                return;
            }
            if (null == ManagerProjectInfo)
            {
                Common.ErrAlert("请选择项目后再操作！");
                return;
            }
            if (MessageBox.Show(string.Format("真的要删除管理人员 {0} 吗？", manager.workerName), "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            CommonResponseData commonResponseData = new CommonResponseData();
            ManagerRequestService.RequestDelAction(manager, loginUser, ref commonResponseData);
            if (null != commonResponseData)
            {
                if (commonResponseData.success)
                {
                    Common.SuccessAlert("删除成功！");
                    LoadManagersData(manager_comboBox);
                }
                else
                {
                    Common.ErrAlert("删除失败！\n" + commonResponseData.message);
                }
            }
            else
            {
                Common.ErrAlert("网络或服务异常，请联系管理员！");
            }
        }
    }
}
