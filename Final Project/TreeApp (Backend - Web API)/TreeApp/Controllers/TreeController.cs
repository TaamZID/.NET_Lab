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
    public class TreeController : ApiController
    {
        [Route("api/tree/add")]
        [HttpPost]
        public void Add(TreeModel e)
        {
            TreeService.Create(e);
        }

        [Route("api/tree/All")]
        [HttpGet]
        public List<TreeModel> GetAll()
        {
            return TreeService.Get();
        }
        [Route("api/tree/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, TreeService.Get(id));
        }
        [Route("api/tree/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(TreeModel user)
        {
            TreeService.Edit(user);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/tree/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            TreeService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("api/tree/Search/{search}")]
        [HttpGet]
        public List<TreeModel> SearchTree(string search)
        {
            return TreeService.SearchTree(search);
        }
    }
}
