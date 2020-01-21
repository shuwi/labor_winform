using System.Collections.Generic;

namespace LaborStackApp.Response
{
    public class TeamDataResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public List<TeamData> data { get; set; }
    }
}
