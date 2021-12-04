using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class MEM_LOG_REPO
    {
        static projectManagementEntities db;

        static MEM_LOG_REPO()
        {
            db = new projectManagementEntities();
        }

        public static List<MEM_LOG_TABLE> GetAll()
        {
            return db.MEM_LOG_TABLE.ToList();
        }

        public static MEM_LOG_TABLE GetLOG(string MNAME, string MPASSWORD)
        {
            return db.MEM_LOG_TABLE.FirstOrDefault(e => e.MNAME == MNAME && e.MPASSWORD == MPASSWORD);
        }
    }
}
