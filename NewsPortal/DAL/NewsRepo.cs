using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo
    {
        static NewsPortalEntities2 db;

        static NewsRepo()
        {
            db = new NewsPortalEntities2();
        }

        public static List<News> Get()
        {
            return db.News.ToList();
        }

        public static News Get(int id)
        {
            return db.News.FirstOrDefault(e => e.N_id == id);
        }

        public static void Edit(News n)
        {
            var ds = db.News.FirstOrDefault(e => e.N_id == n.N_id);
            db.Entry(ds).CurrentValues.SetValues(n);
            db.SaveChanges();
        }

        public static void Delete(int id)
        {
            var ds = db.News.FirstOrDefault(e => e.N_id == id);
            db.News.Remove(ds);
        }

        public static void Add(News n)
        {
            db.News.Add(n);
            db.SaveChanges();
        }
    }
}
