using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVG.LojaVirtual.Dominio.Entidade;
using TVG.LojaVirtual.Dominio.Repositorio;
using TVG.LojaVirtual.Web.Models;

namespace TVG.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 12;

        // GET: Vitrine
        //public ViewResult ListaProdutos(string categoria, int pagina = 1)
        //{
        //    _repositorio = new ProdutosRepositorio();
        //    ProdutosViewModel model = new ProdutosViewModel
        //    {

        //        Produtos = _repositorio.Produtos
        //        .Where(p => categoria == null || p.Categoria == categoria)
        //        .OrderBy(p => p.Descricao)
        //        .Skip((pagina - 1) * ProdutosPorPagina)
        //        .Take(ProdutosPorPagina),


        //        Paginacao = new Paginacao
        //        {
        //            PaginaAtual = pagina,
        //            ItensPorPagina = ProdutosPorPagina,
        //            ItensTotal = categoria == null ? _repositorio.Produtos.Count() : _repositorio.Produtos.Where(p => p.Categoria == categoria).Count()
        //        },

        //        CategoriaAtual = categoria
        //    };

            

        //    return View(model);
        //}

        public ViewResult ListaProdutos(string categoria)
        {
            _repositorio = new ProdutosRepositorio();
            var model  = new ProdutosViewModel();
            var rnd = new Random(); // produtos aleatorios para vitrine

            if (categoria != null)
            {
                model.Produtos = _repositorio.Produtos
                    .Where(p => p.Categoria == categoria).OrderBy(p => rnd.Next()).ToList();
            }
            else
            {
                model.Produtos = _repositorio.Produtos
                        .OrderBy(p => rnd.Next())
                        .Take(ProdutosPorPagina).ToList();
            }

            return View(model);
        }

        [Route("Vitrine/ObterImagem/{produtoId}")]
        public FileContentResult ObterImagem(int produtoId)
        {
            _repositorio = new ProdutosRepositorio();

            Produto prod = _repositorio.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (prod != null)
            {
                return File(prod.Imagem, prod.ImagemMimeType);
            }

            return null;
        }

        [Route("DetalhesProduto/{id}/{produto}")]
        public ViewResult Detalhes(int id)
        {
            _repositorio = new ProdutosRepositorio();

            Produto prod = _repositorio.ObterProduto(id);

            return View(prod);
        }
    }
}