using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ClsUsuario
    {
        public static Usuario BuscarPorId(int usuarioid)
        {
            EntidadesDataContext context = new EntidadesDataContext();
            Usuario user = null;
            var query = context.Usuario.Where(p => p.idUsuario == usuarioid).Select(p => p);

            if (query.Count() > 0)
                user = query.First();
            return user;
        }
    }
}
