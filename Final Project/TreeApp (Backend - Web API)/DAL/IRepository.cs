using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<T, ID>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
        void Edit(T e);
        void Delete(ID id);
    }

    public interface IRepo<T, ID>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
        void Delete(ID id);
        void Edit(T e);
    }

    public interface IRep<T, ID, STRING>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
        void Edit(T e);
        void Delete(ID id);
        List<T> SearchTree(STRING search);
        List<T> GetByDate(STRING search);
    }
    public interface IRe<T, ID>
    {
        void Add(T e);
        List<T> Get();
        T Get(ID id);
        void Edit(T e);
        void Delete(ID id);
    }
}