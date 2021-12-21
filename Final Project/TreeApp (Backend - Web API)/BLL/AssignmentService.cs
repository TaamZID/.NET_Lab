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
    public class AssignmentService
    {
        //static AssignmentService()
        //{
            //Mapper.Initialize(cfg => {
                //cfg.CreateMap<assignment, AssignmentModel>();
                //cfg.CreateMap<AssignmentModel, assignment>();
            //});
        //}
        public static List<AssignmentModel> Get()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<assignment, AssignmentModel>());
            var data = AutoMapper.Mapper.Map<List<AssignmentModel>>(DataAccessFactory.AssignmentDataAccess().Get());
            return data;
        }
        public static AssignmentModel Get(int id)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<assignment, AssignmentModel>());
            var data = Mapper.Map<AssignmentModel>(DataAccessFactory.AssignmentDataAccess().Get(id)); 
            return data;
        }
        public static void Create(AssignmentModel user)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<AssignmentModel, assignment>());
            var data = Mapper.Map<assignment>(user);
            DataAccessFactory.AssignmentDataAccess().Add(data);
        }
        public static void Edit(AssignmentModel user)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<AssignmentModel, assignment>());
            var data = Mapper.Map<assignment>(user);
            DataAccessFactory.AssignmentDataAccess().Edit(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.AssignmentDataAccess().Delete(id);
        }
    }
}
