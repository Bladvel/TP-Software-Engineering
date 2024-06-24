using EjemploArquitectura.Domain;
using EjemploArquitectura.SqlServerDataProvider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Repository
{
    public class UsuarioRepository
    {
        UsuarioSqlServerDataProvider _context;

        public UsuarioRepository()
        {
            _context = new UsuarioSqlServerDataProvider();
        }

        public Usuario ObtenerUsuarioPorUsernamePassword(string username, string password)
        {
            return _context.ObtenerUsuarioPorUsernamePassword(username, password);
        }
        public Usuario ObtenerUsuarioPorId(Guid id)
        {
            return _context.ObtenerUsuarioPorId(id);
         }
    }
}
