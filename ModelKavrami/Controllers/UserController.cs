using ModelKavrami.Filters;
using ModelKavrami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ModelKavrami.Controllers
{
    public class UserController : ApiController
    {
        [ModelValidation]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] User user)
        {
            return Request.CreateResponse(HttpStatusCode.Created, "Kullanıcı oluşturuldu.");  
        }
    }
}
