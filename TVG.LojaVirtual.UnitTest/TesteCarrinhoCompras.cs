using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVG.LojaVirtual.Dominio.Entidade;

namespace TVG.LojaVirtual.UnitTest
{
    [TestClass]
    public class TesteCarrinhoCompras
    {
        [TestMethod]
        public void AdicionarItensAoCarrinho()
        {
            //Arrange - criaçao produtos
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "Teste 1"
            };
            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste 2"
            };
            Produto produto3 = new Produto
            {
                ProdutoId = 3,
                Nome = "Teste 3"
            };

            //Arrange - criaçao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarItem(produto1, 2);
            carrinho.AdicionarItem(produto2, 3);
            carrinho.AdicionarItem(produto3, 3);

            //Act
            ItemCarrinho[] itens = carrinho.ItensCarrinho.ToArray();

            //Assert
            // se tem 2 itens no carrinho?
            Assert.AreEqual(itens.Length, 3);

            Assert.AreEqual(itens[0].Produto, produto1);
            Assert.AreEqual(itens[1].Produto, produto2);
        }

        [TestMethod]
        public void AdicionarProdutoExistenteAoCarrinho()
        {
        
            //Arrange - criaçao produtos
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "Teste 1"
            };
            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste 2"
            };

            //Arrange - criaçao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);
            carrinho.AdicionarItem(produto1, 10);

            //Act
            ItemCarrinho[] resultado = carrinho.ItensCarrinho
                .OrderBy(c => c.Produto.ProdutoId).ToArray();

            Assert.AreEqual(resultado.Length, 2);
            Assert.AreEqual(resultado[0].Quantidade, 11);
        }

        [TestMethod]
        public void RemoverItensCarrinho()
        {
            //Arrange - criaçao produtos
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "Teste 1"
            };
            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste 2"
            };
            Produto produto3 = new Produto
            {
                ProdutoId = 3,
                Nome = "Teste 3"
            };

            //Arrange - criaçao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 3);
            carrinho.AdicionarItem(produto3, 5);
            carrinho.AdicionarItem(produto2, 1);
            carrinho.RemoverItem(produto2);

            Assert.AreEqual(carrinho.ItensCarrinho.Where(c => c.Produto == produto2).Count(), 0);
            Assert.AreEqual(carrinho.ItensCarrinho.Count(), 2);
        }

        [TestMethod]
        public void CalcularValorTotal()
        {
            //Arrange - criaçao produtos
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "Teste 1",
                Preco = 100M
            };
            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste 2",
                Preco = 50M
            };

            //Arrange - criaçao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);
            carrinho.AdicionarItem(produto1, 3);

            decimal resultado = carrinho.ObterValorTotal();

            Assert.AreEqual(resultado, 450M);
        }

        [TestMethod]
        public void LimparItensCarrinho()
        {
            //Arrange - criaçao produtos
            Produto produto1 = new Produto
            {
                ProdutoId = 1,
                Nome = "Teste 1",
                Preco = 100M
            };
            Produto produto2 = new Produto
            {
                ProdutoId = 2,
                Nome = "Teste 2",
                Preco = 50M
            };

            //Arrange - criaçao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarItem(produto1, 1);
            carrinho.AdicionarItem(produto2, 1);

            carrinho.LimparCarrinho();

            Assert.AreEqual(carrinho.ItensCarrinho.Count(), 0);
        }
    }
}
