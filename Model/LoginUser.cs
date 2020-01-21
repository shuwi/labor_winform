using SQLite;

namespace LaborStackApp.Model
{
    public class LoginUser
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string DepartId { get; set; }
        public string OrganizationCode { get; set; }
        public string LoginToken { get; set; }
        public string LoginDate { get; set; }
        public int RememberMe { get; set; }
    }
}
