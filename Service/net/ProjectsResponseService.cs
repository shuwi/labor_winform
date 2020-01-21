using LaborStackApp.Model;
using LaborStackApp.Response;
using LaborStackApp.Toolkits;
using System.Configuration;

namespace LaborStackApp.Service.net
{
    public class ProjectsResponseService
    {
        /// <summary>
        /// 获取项目数据
        /// </summary>
        /// <param name="loginUser"></param>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectsResponse"></param>
        public static void Response(LoginUser loginUser,int pageNum, int pageSize, ref ProjectsResponseData projectsResponse)
        {
            object data = new
            {
                organizationCode = loginUser.OrganizationCode,
                isEnterprise = 0,
                account = loginUser.AccountName,
                pageNo = 1,
                pageSize = 1000
            };
            Common.GetRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.GetProjectsByCompany, loginUser.LoginToken, "application/x-www-form-urlencoded", ref projectsResponse);
        }
    }
}
