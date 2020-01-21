using SQLite;

namespace LaborStackApp.Model
{
    public class ProjectWorker
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string IdCardNumber { get; set; }
        public string IdCardPhoto { get; set; }
        public string IsSue { get; set; }
        public string Nation { get; set; }
        public string NationName { get; set; }
        public string ProjectCode { get; set; }
        public string TeamName { get; set; }
        public string TeamSysNo { get; set; }
        public string WorkTypeCode { get; set; }
        public string WorkTypeName { get; set; }
        public string WorkerName { get; set; }
    }
}
