using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {

            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text==txtConfirmar.Text)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string usuario = txtUser.Text;
                string password = txtPassword.Text;
                DateTime fecha = DateTime.Parse(txtDate.Text);
                string pais = txtPais.Text;
                string email = txtCorreo.Text;

                int resultado = ClsUsuario.RegistrarUsuario(nombre, apellido, usuario, password, fecha, pais, email);
                if(resultado==1)
                    Response.Write("<script> alert(" + "'Nombre de usuario no disponible, escoga otro.'" + ") </script>");
                else if (resultado == 2)
                    Response.Write("<script> alert(" + "'Algo salió mal en el registro, revise sus datos.'" + ") </script>");
                else if (resultado == 3)
                    Response.Write("<script> alert(" + "'Registro completado exitosamente.'" + ") </script>");
            }
            else
            {
                Response.Write("<script> alert(" + "'Las contraseñas no coinciden.'" + ") </script>");
            }
            
        }
        /*private void VerificarSesion()
        {
            if (Session["usuarioId"] == null)
                Response.Redirect("~Inicio.aspx");
        }*/

        protected void lnkLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inicio.aspx");
        }
    }
}