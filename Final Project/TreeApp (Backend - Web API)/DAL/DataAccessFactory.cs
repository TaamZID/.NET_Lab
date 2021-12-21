using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static tree_plantation_dbEntities db;
        static DataAccessFactory()
        {
            db = new tree_plantation_dbEntities();
        }
        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new TokenRepo(db);
        }
        public static IAuth AuthDataAccess()
        {
            return new UserRepo(db);
        }
        public static IRepo<assignedtask, int> assignedtasksDataAcess()
        {
            return new AssignedtasksRepo(db);
        }
        public static IRep<tree, int, string> TreeDataAccess()
        {
            return new TreeRepo(db);
        }
        public static IRe<assignment, int> AssignmentDataAccess()
        {
            return new AssignmentRepo(db);
        }
    }
}