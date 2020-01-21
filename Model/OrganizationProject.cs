using SQLite;

namespace LaborStackApp.Model
{
    public class OrganizationProject
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Area { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int ProjectStatus { get; set; }
        public int ProjectType { get; set; }
        public string OrganizationCode { get; set; }
    }
}
