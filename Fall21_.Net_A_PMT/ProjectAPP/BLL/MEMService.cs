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
    public class MEMService
    {
        public static List<MEMmodel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MEM_LOG_TABLE, MEMmodel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<MEMmodel>>(MEM_LOG_REPO.GetAll());

            return data;
        }
        public static MEMmodel GetLOG(string MNAME, string MPASSWORD)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MEM_LOG_TABLE, MEMmodel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<MEMmodel>(MEM_LOG_REPO.GetLOG(MNAME, MPASSWORD));
            return data;
        }
    }
}
