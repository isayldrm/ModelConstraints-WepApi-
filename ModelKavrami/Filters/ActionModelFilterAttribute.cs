using System;
using System.Web.Http.Controllers;

namespace ModelKavrami.Filters
{
    public class ActionModelFilterAttribute
    {
        internal void OnActionExecuting(HttpActionContext actionContext)
        {
            throw new NotImplementedException();
        }
    }
}