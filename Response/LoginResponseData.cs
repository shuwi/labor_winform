using System.Collections.Generic;

namespace LaborStackApp.Response
{
    public class LoginResponseData
    {
        public int projectCounts { get; set; }
        public UserInfo userInfo { get; set; }
        public List<WorkerType> workerTypeList { get; set; }
        public List<CultureLevelType> cultureLevelTypeList { get; set; }
        public List<Nation> nationList { get; set; }
    }
}
