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
    public class SUPService
    {
        public static List<SUPmodel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SUP_LOG_TABLE, SUPmodel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<SUPmodel>>(SUP_LOG_REPO.GetAll());

            return data;
        }
        public static SUPmodel GetLOG(string MNAME, string MPASSWORD)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SUP_LOG_TABLE, SUPmodel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<SUPmodel>(SUP_LOG_REPO.GetLOG(MNAME, MPASSWORD));
            return data;
        }
    }
}
