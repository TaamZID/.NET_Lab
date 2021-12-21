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
    public class ReportController : ApiController
    {
        [Route("api/tree/record/{search}")]
        [HttpGet]
        public List<TreeModel> SearchTree(string search)
        {
            return TreeService.SearchTree(search);
        }
    }
}
