using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVG.LojaVirtual.Dominio.Entidade;

namespace TVG.LojaVirtual.Dominio.Repositorio
{
    public class AdministradoresRepositorio
    {
        private readonly EFDBContext _context = new EFDBContext();

        public Administrador ObterAdministrador(Administrador administrador)
        {
            return _context.Administrador.FirstOrDefault(a => a.Login == administrador.Login);
        }
    }
}
