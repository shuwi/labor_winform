using LaborStackApp.Model;
using LaborStackApp.Request;
using LaborStackApp.Response;
using LaborStackApp.Toolkits;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;

namespace LaborStackApp.Service.net
{
    public class WorkerRequestService
    {
        /// <summary>
        /// 获取工人数据
        /// </summary>
        /// <param name="loginUser"></param>
        /// <param name="WorkerProjectCode"></param>
        /// <param name="workers_pageUserControl">自定义的分页用户控件</param>
        /// <param name="workerListResponse"></param>
        public static void Response(LoginUser loginUser, string WorkerProjectCode, PageUserControl workers_pageUserControl, ref WorkersResponse workerListResponse)
        {
            object data = new
            {
                projectCode = WorkerProjectCode,
                pageNo = workers_pageUserControl.PageIndex,
                pageSize = workers_pageUserControl.PageSize,
                organizationCode = loginUser.OrganizationCode
            };
            Common.GetRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.GetAppWorkerMasterByProjectCode, loginUser.LoginToken, "application/x-www-form-urlencoded", ref workerListResponse);
        }
        /// <summary>
        /// 提交新增工人请求
        /// </summary>
        /// <param name="workerAddRequestData"></param>
        /// <param name="loginUser"></param>
        /// <param name="WorkerProjectCode"></param>
        /// <param name="commonResponse"></param>
        public static void RequestAddAction(WorkerAddRequestData workerAddRequestData, LoginUser loginUser, ref CommonResponseData commonResponse)
        {
            List<WorkerAddRequestData> list = new List<WorkerAddRequestData>();
            list.Add(workerAddRequestData);
            object data = new
            {
                workerListStr = JsonConvert.SerializeObject(list),
                type = 3
            };
            Common.PostRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.AddWorkers, loginUser.LoginToken, "application/json", ref commonResponse);
        }
        /// <summary>
        /// 提交删除工人请求
        /// </summary>
        /// <param name="workerDeleteRequestData"></param>
        /// <param name="loginUser"></param>
        /// <param name="commonResponse"></param>
        public static void RequestDelAction(WorkerListData worker, LoginUser loginUser, ref CommonResponseData commonResponse)
        {
            object data = new
            {
                worker.projectCode,
                worker.teamSysNo,
                idCardType = 1,
                worker.idCardNumber
            };
            Common.PostRequest(data, ConfigurationManager.AppSettings["baseURL"].ToString(), Properties.Resources.DeleteWorker, loginUser.LoginToken, "application/json", ref commonResponse);
        }
    }
}
