using System.Web.Optimization;
namespace TVG.LojaVirtual.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery-1.10.2.intellisense.js
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery-1.10.2.js
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery-1.10.2.min.js
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery-1.10.2.min.map
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-1.*"
                ));

            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery.validate-vsdoc.js
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery.validate.js
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery.validate.min.js
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery.validate.unobtrusive.js
            //D:\PROJETOS\Projetos\TVG.LojaVirtual\TVG.LojaVirtual.Web\Scripts\jquery.validate.unobtrusive.min.js
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap-theme.css",
                "~/Content/ErroEstilo.css"
                ));

            BundleTable.EnableOptimizations = false;
        }
    }
}