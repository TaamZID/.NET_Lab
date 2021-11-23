using BLL;
using BLL.BEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class NewsController : ApiController
    {
        [Route("api/News/Category")]
        [HttpGet]
        public List<string> GetCategory()
        {
            return NewsService.GetCategory();
        }
        [Route("api/News/All")]
        [HttpGet]
        public List<NewsModel> Get()
        {
            return NewsService.Get();
        }
        [Route("api/News/Create")]
        [HttpPost]
        public void Add(NewsModel n)
        {
            NewsService.Add(n);
        }
    }
}
