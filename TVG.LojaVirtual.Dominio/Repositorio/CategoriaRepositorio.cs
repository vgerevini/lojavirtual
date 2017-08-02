using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVG.LojaVirtual.Dominio.Entidade;

namespace TVG.LojaVirtual.Dominio.Repositorio
{
    public class CategoriaRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();

        public IEnumerable<Categoria> ObterCategorias()
        {
            return _context.Categorias.OrderBy(c => c.CategoriaDescricao);
        }
    }
}
