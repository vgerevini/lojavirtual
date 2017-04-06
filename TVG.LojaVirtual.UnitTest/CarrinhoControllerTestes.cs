using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVG.LojaVirtual.Dominio.Entidade;
using TVG.LojaVirtual.Web.Controllers;

namespace TVG.LojaVirtual.UnitTest
{
    [TestClass]
    public class CarrinhoControllerTestes
    {
        [TestMethod]
        public void AdcionarItensCarrinho()
        {
            //Arrange
            Produto produto1 = new Produto() { 
                ProdutoId = 1,
                Nome = "Produto1"
            };
            Produto produto2 = new Produto()
            {
                ProdutoId = 2,
                Nome = "Produto2"
            };
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarItem(produto1, 3);

            //Act
            CarrinhoController controller = new CarrinhoController();
            controller.Adicionar(carrinho, 2,1, "");

            //Assert
            Assert.AreEqual(carrinho.ItensCarrinho.Count(), 1);
            Assert.AreEqual(carrinho.ItensCarrinho.ToArray()[0].Produto.ProdutoId, 1);

        }
    }
}
