using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class SUP_LOG_REPO
    {
        static projectManagementEntities db;

        static SUP_LOG_REPO()
        {
            db = new projectManagementEntities();
        }

        public static List<SUP_LOG_TABLE> GetAll()
        {
            return db.SUP_LOG_TABLE.ToList();
        }
        public static SUP_LOG_TABLE GetLOG(string SNAME, string SPASSWORD)
        {
            return db.SUP_LOG_TABLE.FirstOrDefault(e => e.SNAME == SNAME && e.SPASSWORD == SPASSWORD);
        }
    }
}
