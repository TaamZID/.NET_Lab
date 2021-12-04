using BLL.BEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;

namespace ProjectAPP.Controllers
{
    public class SUPController : ApiController
    {
        [Route("api/Project/Supervisor")]
        [HttpGet]

        public List<SUPmodel> Get()
        {
            return SUPService.GetAll();
        }
    }
}
