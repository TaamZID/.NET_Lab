using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;

namespace ProjectAPP.Controllers
{
    public class LOGController : ApiController
    {
        [Route("api/Project/Login")]
        [HttpPost]
        public void GetLogin(string SNAME, string SPASSWORD)
        {
            var MEM = MEMService.GetLOG(SNAME, SPASSWORD);
            var SUP = SUPService.GetLOG(SNAME, SPASSWORD);

            if (MEM != null)
            {
                FormsAuthentication.SetAuthCookie(MEM.MPASSWORD, true);
            }

            else if (SUP != null)
            {
                FormsAuthentication.SetAuthCookie(SUP.SPASSWORD, true);
            }
        }
    }
}
