using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVG.LojaVirtual.Dominio.Entidade;
using TVG.LojaVirtual.Dominio.Entidade.Vitrine;

namespace TVG.LojaVirtual.Dominio.Repositorio
{
    public class MenuRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();

        public IEnumerable<Categoria> ObterCategorias()
        {
            return _context.Categorias.OrderBy(c => c.CategoriaDescricao);
        }

        public IEnumerable<MarcaVitrine> ObterMarcas()
        {
            return _context.MarcaVitrine.OrderBy(m => m.MarcaDescricao);
        }

        public IEnumerable<ClubesNacionais> ObterClubesNacionais()
        {
            return _context.ClubesNacionais.OrderBy(c => c.LinhaDescricao);
        }

        public IEnumerable<ClubesInternacionais> ObterClubesInternacionais()
        {
            return _context.ClubesInternacionais.OrderBy(c => c.LinhaDescricao);
        }

        public IEnumerable<Selecoes> ObterSelecoes()
        {
            return _context.Selecoes.OrderBy(c => c.LinhaDescricao);
        }

        //public IEnumerable<Genero> ObterGeneros()
        //{
        //    return _context.Genero.OrderBy(g => g.GeneroDescricao);
        //}

        //public IEnumerable<FaixaEtaria> ObterFaixasEtarias()
        //{
        //    return _context.FaixaEtaria.OrderBy(f => f.FaixaEtariaDescricao);
        //}

        //public IEnumerable<Grupo> ObterGrupos()
        //{
        //    return _context.Grupo.OrderBy(g => g.GrupoDescricao);
        //}

        //public IEnumerable<SubGrupo> ObterSubGrupos()
        //{
        //    return _context.SubGrupo.OrderBy(s => s.SubGrupoDescricao);
        //}

        //public IEnumerable<Modalidade> ObterModalidades()
        //{
        //    return _context.Modalidade.OrderBy(m => m.ModalidadeDescricao);
        //}
    }
}
