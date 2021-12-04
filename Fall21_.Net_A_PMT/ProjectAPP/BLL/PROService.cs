using AutoMapper;
using BLL.BEntity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PROService
    {
        public static List<PROmodel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PRO_TABLE, PROmodel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<PROmodel>>(PRO_REPO.GetAll());

            return data;
        }
        //public static PROmodel GetPRO(int id) { 
        //var data = PRO_REPO.GetPRO(id);
        //var d = Mapper.Map<PRO_TABLE, PROmodel>(data);
        //return d;
        //}

        public static void Add(PROmodel e)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<PROmodel, PRO_TABLE>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<PRO_TABLE>(e);
            PRO_REPO.Add(data);
        }
    }
}
