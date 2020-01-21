using LaborStackApp.Model;
using LaborStackApp.Response;
using LaborStackApp.Toolkits;
using System.Configuration;

namespace LaborStackApp.Service.net
{
    public class TeamRequestService
    {
        /// <summary>
        /// 获取班组数据
        /// </summary>
        /// <param name="loginUser"></param>
        /// <param name="GroupProjectCode"></param>
        /// <param name="teamDataResponse"></param>
        public static void Response(LoginUser loginUser, string GroupProjectCode, ref TeamDataResponse teamDataResponse)
        {
            object data = new
            {
                projectCode = GroupProjectCode,
                organizationCode = loginUser.OrganizationCode
            };
            Common.GetRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.GetTeamsByProjectCode, loginUser.LoginToken, "application/x-www-form-urlencoded", ref teamDataResponse);
        }
        /// <summary>
        /// 新增班组
        /// </summary>
        /// <param name="teamData"></param>
        /// <param name="loginUser"></param>
        /// <param name="commonResponse"></param>
        public static void RequestAddAction(TeamData teamData, LoginUser loginUser, ref CommonResponseData commonResponse)
        {
            object data = new
            {
                teamData.teamName,
                teamData.projectCode,
                teamData.organizationCode
            };
            Common.PostRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.AddTeam, loginUser.LoginToken, "application/json", ref commonResponse);
        }
        /// <summary>
        /// 更新班组
        /// </summary>
        /// <param name="teamData"></param>
        /// <param name="loginUser"></param>
        /// <param name="commonResponse"></param>
        public static void RequestUpdateAction(TeamData teamData, LoginUser loginUser, ref CommonResponseData commonResponse)
        {
            object data = new
            {
                teamData.id,
                teamData.teamName,
                teamData.organizationCode
            };
            Common.PostRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.UpdateTeam, loginUser.LoginToken, "application/json", ref commonResponse);
        }
        /// <summary>
        /// 删除班组
        /// </summary>
        /// <param name="teamData"></param>
        /// <param name="loginUser"></param>
        /// <param name="commonResponse"></param>
        public static void RequestDelAction(TeamData teamData, LoginUser loginUser, ref CommonResponseData commonResponse)
        {
            object data = new
            {
                teamData.id,
                teamData.organizationCode
            };
            Common.PostRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.DeleteTeam, loginUser.LoginToken, "application/x-www-form-urlencoded", ref commonResponse);
        }
    }
}
