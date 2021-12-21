using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TreeApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AssignedtasksController : ApiController
    {
        [Route("api/task/Assign")]
        [HttpPost]
        public void Add(AssignedtasksModel e)
        {
            AssignedtasksService.Create(e);
        }

        [Route("api/task/All")]
        [HttpGet]
        public List<AssignedtasksModel> GetAll()
        {
            return AssignedtasksService.Get();
        }
    }
}
