using LaborStackApp.Model;
using LaborStackApp.Response;
using LaborStackApp.Service.net;
using LaborStackApp.Toolkits;
using log4net;
using Newtonsoft.Json;
using SQLite;
using System.Windows.Forms;

namespace LaborStackApp.Modal
{
    public partial class TeamInfoForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(TeamInfoForm));

        private SQLiteConnection db;
        private ProjectInfo projectInfo;
        private LoginUser loginUser;
        private TeamData teamData;

        public TeamInfoForm(SQLiteConnection db, ProjectInfo projectInfo, TeamData teamData, LoginUser loginUser)
        {
            InitializeComponent();
            this.db = db;
            this.projectInfo = projectInfo;
            this.teamData = teamData;
            this.loginUser = loginUser;
        }

        private void TeamInfoForm_Load(object sender, System.EventArgs e)
        {
            team_name_label.Text = projectInfo.projectName;
            if (null == teamData)
            {
                Text = "新增班组";
                return;
            }
            Text = "修改班组";
            team_name_textBox.Text = teamData.teamName;
        }

        private void submit_button_Click(object sender, System.EventArgs e)
        {
            if (string.Empty.Equals(team_name_textBox.Text.Trim()))
            {
                Common.ErrAlert("请填写班组名称！");
                return;
            }
            CommonResponseData commonResponse = new CommonResponseData();
            if (null == teamData)
                AddTeam(commonResponse);
            else
                UpdateTeam(commonResponse);
        }

        private void AddTeam(CommonResponseData commonResponse)
        {
            TeamData data = new TeamData
            {
                teamName = team_name_textBox.Text.Trim(),
                projectCode = projectInfo.projectCode,
                organizationCode = loginUser.OrganizationCode
            };
            TeamRequestService.RequestAddAction(data, loginUser, ref commonResponse);
            if (null != commonResponse)
            {
                if (commonResponse.success)
                {
                    Common.SuccessAlert("新增成功！");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    Common.ErrAlert("新增操作发生数据解析错误！");
                    DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                Common.ErrAlert("新增操作异常，请检查网络连接或联系管理员！");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void UpdateTeam(CommonResponseData commonResponse)
        {
            TeamData data = new TeamData
            {
                id = teamData.id,
                teamName = team_name_textBox.Text.Trim(),
                projectCode = projectInfo.projectCode,
                organizationCode = loginUser.OrganizationCode
            };
            TeamRequestService.RequestUpdateAction(data, loginUser, ref commonResponse);
            log.Debug(JsonConvert.SerializeObject(commonResponse, Formatting.Indented));
            if (null != commonResponse)
            {
                if (commonResponse.success)
                {
                    Common.SuccessAlert("修改操作成功！");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    Common.ErrAlert("修改操作发生数据解析错误！");
                    DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                Common.ErrAlert("修改操作异常，请检查网络连接或联系管理员！");
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
