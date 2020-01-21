using SQLite;

namespace LaborStackApp.Model
{
    public class WorkerType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string WorkerTypeName { get; set; }
        public int Pid { get; set; }
        public int Num { get; set; }
        public int RemoteId { get; set; }
        public string OrganizationCode { get; set; }
    }
}
