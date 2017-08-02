using TVG.LojaVirtual.Dominio.Entidade;

namespace TVG.LojaVirtual.Web.Models
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }
        public string ReturnUrl { get; set; }
    }
}