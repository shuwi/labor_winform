using System.Collections.Generic;

namespace LaborStackApp.Response
{
    public class ProjectsResponseData
    {
        public int code { get; set; }
        public bool success { get; set; }
        public List<ProjectInfo> data { get; set; }
    }
}
