using CaelumEstoque.Fitros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalGilter(GlobalFilterCollection filters)
        {
            //filters.Add(new AutorizacaoFilterAttribute());
        }
    }
}