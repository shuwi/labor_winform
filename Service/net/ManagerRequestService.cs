using LaborStackApp.Model;
using LaborStackApp.Request;
using LaborStackApp.Response;
using LaborStackApp.Toolkits;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;

namespace LaborStackApp.Service.net
{
    public class ManagerRequestService
    {
        public static void RequestAddAction(ManagerAddRequestData managerAddRequestData, 
            LoginUser loginUser, 
            ref CommonResponseData commonResponse)
        {
            List<ManagerAddRequestData> list = new List<ManagerAddRequestData>();
            list.Add(managerAddRequestData);
            object data = new
            {
                employeeListStr = JsonConvert.SerializeObject(list),
                type = 3
            };
            Common.PostRequest(data, 
                ConfigurationManager.AppSettings["baseURL"].ToString(), 
                Properties.Resources.AddEmployees, 
                loginUser.LoginToken, 
                "application/json", 
                ref commonResponse);
        }

        public static void Response(LoginUser loginUser, 
            string ManagerProjectCode, 
            PageUserControl workers_pageUserControl, 
            ref ManagersResponse workerListResponse)
        {
            object data = new
            {
                projectCode = ManagerProjectCode,
                pageNumber = workers_pageUserControl.PageIndex,
                pageSize = workers_pageUserControl.PageSize,
                organizationCode = loginUser.OrganizationCode
            };
            Common.GetRequest(data, 
                ConfigurationManager.AppSettings["baseURL"].ToString(), 
                Properties.Resources.SelectEmployeesByProjectCode, 
                loginUser.LoginToken, 
                "application/x-www-form-urlencoded", 
                ref workerListResponse);
        }

        public static void RequestDelAction(ManagerListData manager, 
            LoginUser loginUser, 
            ref CommonResponseData commonResponse)
        {
            object data = new
            {
                manager.projectCode,
                idCardType = 1,
                manager.idCardNumber
            };
            Common.PostRequest(data, 
                ConfigurationManager.AppSettings["baseURL"].ToString(), 
                Properties.Resources.DeleteWorker, 
                loginUser.LoginToken, 
                "application/json", 
                ref commonResponse);
        }
    }
}
