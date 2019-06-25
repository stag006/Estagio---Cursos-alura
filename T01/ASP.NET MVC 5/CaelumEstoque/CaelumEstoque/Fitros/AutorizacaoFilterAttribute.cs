using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CaelumEstoque.Fitros
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {        

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            object usuario = filterContext.HttpContext.Session["usuarioLogado"];
            if (usuario == null)
            {
                filterContext.Result = RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { controller = "Login", action = "Index"}
                    )    
                );
            }
        }
    }
}