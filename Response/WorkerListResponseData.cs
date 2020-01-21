using System.Collections.Generic;

namespace LaborStackApp.Response
{
    public class WorkerListResponseData
    {
        public int workerCounts { get; set; }
        public List<WorkerListData> workerList { get; set; }
    }
}
