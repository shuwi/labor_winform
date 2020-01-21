using LaborStackApp.Model;
using LaborStackApp.Service.Inter;
using SQLite;

namespace LaborStackApp.Service
{
    public class LoginUserService : LaborServiceInterface<LoginUser>
    {
        private SQLiteConnection db;
        public LoginUserService(SQLiteConnection db)
        {
            this.db = db;
        }

        public bool AddSingle(LoginUser obj)
        {
            return db.Insert(obj) == 1;
        }

        public LoginUser GetSingle(object[] paramsList)
        {
            return db.FindWithQuery<LoginUser>("SELECT * FROM LoginUser WHERE Id = ?", 1);
        }

        public bool UpdateSingle(LoginUser obj)
        {
            return db.Update(obj) == 1;
        }

    }
}
