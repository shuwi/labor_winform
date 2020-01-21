using System.Collections.Generic;

namespace LaborStackApp.Response
{
    public class ManagersResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public List<ManagerListData> data { get; set; }
    }
}
