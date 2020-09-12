using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsLogin
    {
        public static int IniciarSesion(string user, string password)
        {
            EntidadesDataContext context = new EntidadesDataContext();
            int idUsuario = 0;
            var query = from p in context.Usuario
                        where p.nombreUsuario == user && p.contrasenia == password
                        select p;
            if (query.Count() > 0)
                idUsuario = query.First().idUsuario;
            return idUsuario;
        }
    }
}
