using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TVG.LojaVirtual.Web.Controllers
{
    public class ClienteController : Controller
    {
        
        [Route("Teste")]
        public ActionResult Index()
        {
            ViewBag.Controller = "Cliente";
            return View();
        }

        [Route("usuario/Adicionar/{usuario}/{id}")]
        public string Adicionar(string usuario, int id)
        {
            return string.Format("Usuario: {0}, Id: {1}", usuario, id);
        }
    }
}