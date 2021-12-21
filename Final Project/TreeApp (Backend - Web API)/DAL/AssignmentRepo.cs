using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class AssignmentRepo : IRe<assignment, int>
    {
        tree_plantation_dbEntities db;
        public AssignmentRepo(tree_plantation_dbEntities db)
        {
            this.db = db;
        }
        public List<assignment> GetAll()
        {
            return db.assignments.ToList();
        }
        public void Add(assignment e)
        {
            e.status = "Pending";
            db.assignments.Add(e);
            db.SaveChanges();
        }
        public List<assignment> Get()
        {
            return db.assignments.ToList();
        }

        public assignment Get(int id)
        {
            return db.assignments.FirstOrDefault(e => e.a_number == id);
        }
        public void Delete(int id)
        {
            db.assignments.Remove(db.assignments.FirstOrDefault(e => e.a_number == id));
            db.SaveChanges();
        }

        public void Edit(assignment e)
        {
            var u = db.assignments.FirstOrDefault(en => en.a_id == e.a_id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }
    }
}
