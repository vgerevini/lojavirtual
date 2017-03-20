using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVG.LojaVirtual.Dominio.Entidade;

namespace TVG.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }
    }
}
