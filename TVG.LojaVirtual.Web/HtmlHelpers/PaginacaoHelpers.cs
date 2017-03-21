using System;
using System.Text;
using System.Web.Mvc;
using TVG.LojaVirtual.Web.Models;

namespace TVG.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {

        //Total de paginas = 3
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacao, Func<int, string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i < paginacao.TotalPaginas; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();

                tag.AddCssClass("btn btn-default");
                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                resultado.Append(tag);
            }

            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}