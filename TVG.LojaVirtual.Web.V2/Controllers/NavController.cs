﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVG.LojaVirtual.Web.V2.Models;

namespace TVG.LojaVirtual.Web.V2.Controllers
{
    public class NavController : Controller
    {
        // GET: Nav
        public ActionResult Index()
        {
            return View();
        }

        [Route("nav/{id}/{marca}")]
        public ActionResult ObterProdutosPorMarcas(string id)
        {
            var model = new ProdutosViewModel { produtos = null };

            return View("Index", model);
        }
    }
}