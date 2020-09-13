using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public static int RegistrarUsuario(string nombre, string apellido, string user, string password, DateTime fecha, string pais, string correo)
        {
            int resultado = 0;
            EntidadesDataContext entity = new EntidadesDataContext();
            Usuario usuario = ConsultarPorUser(user);
            

            if(usuario == null)
            {                
                try
                {
                    usuario = new Usuario();
                    usuario.nombre = nombre;
                    usuario.apellido = apellido;
                    usuario.nombreUsuario = user;
                    usuario.contrasenia = password;
                    usuario.fechaNacimiento = fecha;
                    usuario.pais = pais;
                    usuario.correoElectronico = correo;

                    entity.Usuario.InsertOnSubmit(usuario);
                    entity.SubmitChanges();
                    resultado = 3;
                }
                catch (Exception)
                {
                    resultado=2;
                }
            }
            else
            {
                resultado = 1; 
            }
            

            return resultado;
        }

        public static Usuario ConsultarPorUser(string user)
        {
            EntidadesDataContext context = new EntidadesDataContext();
            Usuario usuario = null;
            var query = context.Usuario.Where(u => u.nombreUsuario == user).Select(u => u);
            if (query.Count() > 0)
            {
                usuario = query.First();
            }
            return usuario;
        }

        public static int
            
            ListarUltimoUsuario()
        {
            EntidadesDataContext context = new EntidadesDataContext();
            int usuarioId = 0;
            var query = from u in context.Usuario
                        orderby u.idUsuario descending
                        select u;
            if (query.Count() > 0)
                usuarioId = query.First().idUsuario;
            return usuarioId;
        }
    }
}
