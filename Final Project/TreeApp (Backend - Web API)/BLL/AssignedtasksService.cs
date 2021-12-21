using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AssignedtasksService
    {
        static AssignedtasksService()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<assignedtask, AssignedtasksModel>();
                cfg.CreateMap<AssignedtasksModel, assignedtask>();
            });
        }
        public static List<AssignedtasksModel> Get()
        {
            var data = AutoMapper.Mapper.Map<List<AssignedtasksModel>>(DataAccessFactory.assignedtasksDataAcess().Get());
            return data;
        }
        public static AssignedtasksModel Get(int id)
        {
            var data = Mapper.Map<AssignedtasksModel>(DataAccessFactory.assignedtasksDataAcess().Get(id)); 
            return data;
        }
        public static void Create(AssignedtasksModel user)
        {
            var data = Mapper.Map<assignedtask>(user); 
            DataAccessFactory.assignedtasksDataAcess().Add(data);
        }
        public static void Edit(AssignedtasksModel user)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<AssignedtasksModel, assignedtask>());
            var data = Mapper.Map<assignedtask>(user); 
            DataAccessFactory.assignedtasksDataAcess().Edit(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.assignedtasksDataAcess().Delete(id);
        }
    }
}
