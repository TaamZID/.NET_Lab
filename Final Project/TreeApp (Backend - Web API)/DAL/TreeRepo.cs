using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class TreeRepo: IRep<tree, int, string>
    {
        tree_plantation_dbEntities db;
        public TreeRepo(tree_plantation_dbEntities db)
        {
            this.db = db;
        }
        public void Add(tree e)
        {
            db.trees.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.trees.Remove(db.trees.FirstOrDefault(e => e.Id == id));
            db.SaveChanges();
        }

        public void Edit(tree e)
        {
            var u = db.trees.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(u).CurrentValues.SetValues(e);
            db.SaveChanges();

        }

        public List<tree> Get()
        {
            return db.trees.ToList();
        }

        public tree Get(int id)
        {
            return db.trees.FirstOrDefault(e => e.Id == id);
        }
        public List<tree> SearchTree(string search)
        {
            var ss = (from t in db.trees
                        where t.T_Name.Contains(search) || t.Time.Contains(search)
                      select t).ToList();
            return ss;
        }
        public List<tree> GetByDate(string search)
        {

            var entity = (from e in db.trees
                          where e.Time.Contains(search)
                          select e).ToList();
            return entity;
        }
    }
}
