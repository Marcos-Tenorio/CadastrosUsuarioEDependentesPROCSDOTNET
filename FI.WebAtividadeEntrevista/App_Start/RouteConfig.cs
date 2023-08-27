using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebAtividadeEntrevista
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "ClienteController",
               url: "ClienteController/ResultadoValidacaoCPF",
               defaults: new { controller = "ClienteController", action = "ResultadoValidacaoCPF" }
            );

            routes.MapRoute(
              name: "Services",
              url: "Services/validarCpf",
              defaults: new { controller = "Services", action = "validarCpf" }
           );

            routes.MapRoute(
              name: "Incluir",
              url: "Beneficiario/Incluir",
              defaults: new { controller = "Beneficiario", action = "Incluir" }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
