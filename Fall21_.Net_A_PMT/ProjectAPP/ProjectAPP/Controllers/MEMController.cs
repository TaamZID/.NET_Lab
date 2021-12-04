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
    public class MEMController : ApiController
    {
        [Route("api/Project/Member")]
        [HttpGet]

        public List<MEMmodel> Get()
        {
            return MEMService.GetAll();
        }
    }
}
