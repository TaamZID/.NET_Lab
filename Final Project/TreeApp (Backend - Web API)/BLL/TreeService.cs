using AutoMapper;
using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;

namespace BLL
{
    public class TreeService
    {
       // static TreeService()
       // {
          //  Mapper.Initialize(cfg => {
               // cfg.CreateMap<tree, TreeModel>();
                //cfg.CreateMap<TreeModel, tree>();
            //});
        //}
        public static List<TreeModel> Get()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<tree, TreeModel>());
            var data = Mapper.Map<List<TreeModel>>(DataAccessFactory.TreeDataAccess().Get());
            return data;
        }
        public static TreeModel Get(int id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<tree, TreeModel>());
            var data = Mapper.Map<TreeModel>(DataAccessFactory.TreeDataAccess().Get(id));
            return data;
        }
        public static void Create(TreeModel tree)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<TreeModel, tree>());
            var data = Mapper.Map<tree>(tree);
            DataAccessFactory.TreeDataAccess().Add(data);
        }
        public static void Edit(TreeModel tree)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<TreeModel, tree>());
            var data = Mapper.Map<tree>(tree);
            DataAccessFactory.TreeDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.TreeDataAccess().Delete(id);
        }

        public static List<TreeModel> SearchTree(string search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<tree, TreeModel>();
            });
            var mapper = new Mapper(config);
            var s = DataAccessFactory.TreeDataAccess();
            var data = Mapper.Map<List<TreeModel>>(s.SearchTree(search));
            return data;
        }
        public static List<TreeModel> GetByDate(string search)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<tree, TreeModel>();
            });
            var mapper = new Mapper(config);
            var t = DataAccessFactory.TreeDataAccess();
            var data = Mapper.Map<List<TreeModel>>(t.GetByDate(search));
            return data;
        }
    }
}
