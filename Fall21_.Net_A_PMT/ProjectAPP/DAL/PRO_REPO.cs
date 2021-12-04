using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class PRO_REPO
    {
        static projectManagementEntities db;
        static PRO_REPO()
        {
            db = new projectManagementEntities();
        }
        public static List<PRO_TABLE> GetAll()
        {
            var data = db.PRO_TABLE.ToList();
            return data;
        }
        public static PRO_TABLE GetPRO(int id)
        {
            var data = db.PRO_TABLE.FirstOrDefault(e => e.PID == id);
            return data;
        }

        public static void Add(PRO_TABLE P)
        {
            db.PRO_TABLE.Add(P);
            db.SaveChanges();
        }
        public static void Edit(PRO_TABLE P)
        {
            var ED = db.PRO_TABLE.FirstOrDefault(e => e.PID == P.PID);
            db.Entry(ED).CurrentValues.SetValues(P);
            db.SaveChanges();
        }
        public static void Delete(PRO_TABLE D)
        {
            var DE = db.PRO_TABLE.FirstOrDefault(e => e.PID == D.PID);
            db.PRO_TABLE.Remove(DE);
            db.SaveChanges();
        }
    }
}
