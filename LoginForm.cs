using LaborStackApp.Modal;
using LaborStackApp.Model;
using LaborStackApp.Response;
using LaborStackApp.Service;
using LaborStackApp.Service.Inter;
using LaborStackApp.Toolkits;
using log4net;
using SQLite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WorkerType = LaborStackApp.Response.WorkerType;

namespace LaborStackApp
{
    public partial class LoginForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LoginForm));
        private readonly Color BorderColor = Color.FromArgb(220, 220, 220);
        private SQLiteConnection db;
        private LoginUser loginUser = new LoginUser();
        LaborServiceInterface<LoginUser> laborServiceInterface;

        public LoginForm(SQLiteConnection db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            laborServiceInterface = new LoginUserService(db);
            loginUser = laborServiceInterface.GetSingle(null);
            if (null == loginUser)
                return;
            if (loginUser.RememberMe == 0)
                return;
            username_textBox.Text = loginUser.AccountName;
            password_textBox.Text = loginUser.Password;
            remember_me_checkBox.Checked = true;
        }

        private void username_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Common.BorderDraw(sender, e, BorderColor);
        }

        private void password_flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            Common.BorderDraw(sender, e, BorderColor);
        }

        private void signin_button_Click(object sender, EventArgs e)
        {
            if (string.Empty.Equals(username_textBox.Text.Trim()))
            {
                Common.ErrAlert("请输入用户名");
                return;
            }
            if (string.Empty.Equals(password_textBox.Text.Trim()))
            {
                Common.ErrAlert("请输入密码");
                return;
            }
            string path = "loginPost";
            object data = new
            {
                account = username_textBox.Text.Trim(),
                password = Common.GenerateMD5(password_textBox.Text.Trim()),
                userType = 1
            };

            LoginResponse loginResponseData = new LoginResponse();
            Common.PostRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), path, ref loginResponseData);
            if (null == loginResponseData)
            {
                Common.ErrAlert("登录异常，请检查网络连接！");
                return;
            }
            if (!loginResponseData.success)
            {
                if(null == loginResponseData.message)
                    Common.ErrAlert("登录失败，请核实账户！");
                else
                    Common.ErrAlert("登录失败，请核实账户！错误描述：\n" + loginResponseData.message);
                return;
            }
            if (null == loginResponseData.data)
            {
                Common.ErrAlert("登录返回数据格式错误，请核对数据接口！");
                return;
            }
            LoginUser user = new LoginUser
            {
                AccountName = loginResponseData.data.userInfo.accountName,
                Password = password_textBox.Text.Trim(),
                DepartId = loginResponseData.data.userInfo.departId,
                OrganizationCode = loginResponseData.data.userInfo.organizationCode,
                LoginToken = loginResponseData.token,
                LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                RememberMe = remember_me_checkBox.Checked ? 1 : 0
            };
            if (null == loginUser){
                laborServiceInterface.AddSingle(user);
            }
            else
            {
                user.Id = loginUser.Id;
                laborServiceInterface.UpdateSingle(user);
            }
            List<WorkerType> workerTypes = loginResponseData.data.workerTypeList;

            MainForm mainForm = new MainForm(db, workerTypes, loginResponseData.data.nationList);
            Visible = false;
            mainForm.ShowDialog();
            Dispose();
            Close();
        }

        private void site_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Properties.Resources.Site);
        }
    }
}
