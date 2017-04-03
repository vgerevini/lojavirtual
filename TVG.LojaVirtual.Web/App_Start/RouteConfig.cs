﻿using System.Web.Mvc;
using System.Web.Routing;

namespace TVG.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //1 - Inicio: "/"
            routes.MapRoute(null, "", new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null, pagina = 1 });

            // 2 - Todas as categorias da pagina 2 "/Pagina2"
            routes.MapRoute(null,
                "Pagina{pagina}",
                new { controller = "Vitrine", action = "ListaProdutos", categoria = (string)null }, new { pagina = @"\d+" });

            //3 - Primeira página da categoria de futebol "/Futebol"
            routes.MapRoute(null,
                "{categoria}", new { controller = "Vitrine", action = "ListaProdutos", pagina = 1 });

            //4 - Pagina 2 da categoria de futebol "/Gutebol/Pagina 2"
            routes.MapRoute(null,
                "{categoria}/Pagina{pagina}", new { controller = "Vitrine", action = "ListaProdutos" }, new { pagina = @"\d+" });

            routes.MapRoute("ObterImagem",
                "Vitrine/ObterImagem/{produtoId}", new { controller = "Vitrine", action = "ObterImagem", produtoId = UrlParameter.Optional });

            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
