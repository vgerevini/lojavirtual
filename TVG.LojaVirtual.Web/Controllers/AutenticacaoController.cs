﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TVG.LojaVirtual.Dominio.Entidade;
using TVG.LojaVirtual.Dominio.Repositorio;

namespace TVG.LojaVirtual.Web.Controllers
{
    public class AutenticacaoController : Controller
    {
        AdministradoresRepositorio _repositorio;

        // GET: Autenticacao
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View(new Administrador());
        }

        [HttpPost]
        public ActionResult Login(Administrador administrador, string returnUrl)
        {
            _repositorio = new AdministradoresRepositorio();

            if (ModelState.IsValid)
            {
                Administrador admin = _repositorio.ObterAdministrador(administrador);

                if (admin != null)
                {
                    if (!Equals(administrador.Senha, admin.Senha))
                    {
                        ModelState.AddModelError("", "Senha inválida.");
                    }
                    else
                    {
                        FormsAuthentication.SetAuthCookie(admin.Login, false);

                        if (Url.IsLocalUrl(returnUrl) &&
                            returnUrl.Length > 1 &&
                            returnUrl.StartsWith("/") &&
                            !returnUrl.StartsWith("//") &&
                            !returnUrl.StartsWith("/\\"))
                        { 
                            return Redirect(returnUrl); 
                        }
                        return RedirectToAction("Index", "Produto", new { area = "Administrativo" });
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Administrador não encontrado.");
                }
            }

            return View(new Administrador());
        }
    }
}