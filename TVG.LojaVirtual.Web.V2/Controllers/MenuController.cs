using System.Linq;
using System.Web.Mvc;
using System.Web.UI;
using TVG.LojaVirtual.Dominio.Repositorio;

namespace TVG.LojaVirtual.Web.V2.Controllers
{
    public class MenuController : Controller
    {
        private MenuRepositorio _repositorio;

        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Server, VaryByParam = "none")]
        public JsonResult ObterEsportes()
        {
            _repositorio = new MenuRepositorio();

            var cat = _repositorio.ObterCategorias();

            var categoria = from c in cat
                            select new
                            {
                                c.CategoriaDescricao,
                                CategoriaDescricaoSeo = c.CategoriaDescricao.ToSeoUrl(),//melhora url
                                c.CategoriaCodigo
                            };
            return Json(categoria, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Server, VaryByParam = "none")]
        public JsonResult ObterMarcas()
        {
            _repositorio = new MenuRepositorio();

            var listaMarcas = _repositorio.ObterMarcas();

            var marcas = from m in listaMarcas
                         select new
                         {
                             m.MarcaDescricao,
                             MarcaDescricaoSeo = m.MarcaDescricao.ToSeoUrl(),//melhora url
                             m.MarcaCodigo
                         };
            return Json(marcas, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Server, VaryByParam = "none")]
        public JsonResult ObterClubesNacionais()
        {
            _repositorio = new MenuRepositorio();

            var listaclubes = _repositorio.ObterClubesNacionais();

            var clubes = from c in listaclubes
                         select new
                         {
                             ClubeCodigo = c.LinhaCodigo,
                             ClubeSeo = c.LinhaDescricao.ToSeoUrl(),
                             Clube = c.LinhaDescricao
                         };

            return Json(clubes, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Server, VaryByParam = "none")]
        public JsonResult ObterClubesInternacionais()
        {
            _repositorio = new MenuRepositorio();

            var listaclubes = _repositorio.ObterClubesInternacionais();

            var clubes = from c in listaclubes
                         select new
                         {
                             ClubeCodigo = c.LinhaCodigo,
                             ClubeSeo = c.LinhaDescricao.ToSeoUrl(),
                             Clube = c.LinhaDescricao
                         };

            return Json(clubes, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Duration = 3600, Location = OutputCacheLocation.Server, VaryByParam = "none")]
        public JsonResult ObterSelecoes()
        {
            _repositorio = new MenuRepositorio();

            var listaselecoes = _repositorio.ObterSelecoes();

            var selecoes = from c in listaselecoes
                           select new
                           {
                               SelecaoCodigo = c.LinhaCodigo,
                               SelecaoSeo = c.LinhaDescricao.ToSeoUrl(),
                               Selecao = c.LinhaDescricao
                           };

            return Json(selecoes, JsonRequestBehavior.AllowGet);
        }
    }
}