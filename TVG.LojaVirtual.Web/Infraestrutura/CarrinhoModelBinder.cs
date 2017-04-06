using System.Web.Mvc;
using TVG.LojaVirtual.Dominio.Entidade;

namespace TVG.LojaVirtual.Web.Infraestrutura
{
    public class CarrinhoModelBinder : System.Web.Mvc.IModelBinder
    {
        private const string SessionKey = "Carrinho";

        public object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
        {
            //Obtenho carrinho da sessão
            Carrinho carrinho = null;

            if(controllerContext.HttpContext.Session != null)            
                carrinho = (Carrinho)controllerContext.HttpContext.Session["Carrinho"];            

            //Crio o carrinho se nao tiver na sessao
            if(carrinho == null)
                carrinho = new Carrinho();

            if(controllerContext.HttpContext.Session != null)
                controllerContext.HttpContext.Session["Carrinho"] = carrinho;

            //Retorno carrinho
            return carrinho;
        }
    }
}