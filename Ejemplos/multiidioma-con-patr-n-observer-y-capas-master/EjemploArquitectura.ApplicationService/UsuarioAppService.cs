using EjemploArquitectura.Domain;
using EjemploArquitectura.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.ApplicationService
{
    public class UsuarioAppService
    {
        private UsuarioRepository _repo;
        public UsuarioAppService()
        {
            _repo = new UsuarioRepository();
        }
        
        public Usuario ObtenerUsuarioPorId(Guid id)
        {
            return _repo.ObtenerUsuarioPorId(id);
        }
    }
}
