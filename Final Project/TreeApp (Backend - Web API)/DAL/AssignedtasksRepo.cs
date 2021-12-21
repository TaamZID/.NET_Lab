using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AssignedtasksRepo: IRepo<assignedtask, int>
    {
        tree_plantation_dbEntities db;
        public AssignedtasksRepo(tree_plantation_dbEntities db)
        {
            this.db = db;
        }
        public List<assignedtask> GetAll()
        {
            return db.assignedtasks.ToList();
        }
        public void Add(assignedtask e)
        {
            e.status = "Pending";
            db.assignedtasks.Add(e);
            db.SaveChanges();
        }
        public List<assignedtask> Get()
        {
            return db.assignedtasks.ToList();
        }

        public assignedtask Get(int id)
        {
            return db.assignedtasks.FirstOrDefault(e => e.ass_id == id);
        }
        public void Delete(int id)
        {
            db.assignedtasks.Remove(db.assignedtasks.FirstOrDefault(e => e.ass_id == id));
            db.SaveChanges();
        }

        public void Edit(assignedtask e)
        {
            var u = db.assignedtasks.FirstOrDefault(en => en.ass_id == e.ass_id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();
        }
    }
}
