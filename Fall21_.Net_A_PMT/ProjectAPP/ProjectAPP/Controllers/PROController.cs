using BLL;
using BLL.BEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectAPP.Controllers
{
    [EnableCors("*", "*", "*")]
    public class PROController : ApiController
    {
        [Route("api/Project/all")]
        [HttpGet]
        public List<PROmodel> Get()
        {
            return PROService.GetAll();
        }

        [Route("api/Project/Create")]
        [HttpPost]
        public void Add(PROmodel s)
        {

            PROService.Add(s);
        }
        //[Route("api/Project/All/{id}")]
        //[HttpGet]
        //public PROmodel GetPRO(int id)
        //{
        //return PROService.GetPRO(id);
        //}
    }
}
