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
    public class AssignmentController : ApiController
    {
        [Route("api/assignment/submit")]
        [HttpPost]
        public void Add(AssignmentModel e)
        {
            AssignmentService.Create(e);
        }

        [Route("api/assignment/All")]
        [HttpGet]
        public List<AssignmentModel> GetAll()
        {
            return AssignmentService.Get();
        }
        [Route("api/assignment/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, AssignmentService.Get(id));
        }
        [Route("api/assignment/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(AssignmentModel user)
        {
            AssignmentService.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/assignment/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            AssignmentService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
