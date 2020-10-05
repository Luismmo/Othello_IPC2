using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Presentacion
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected ActionResult Iniciar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;

            int usuarioId = ClsLogin.IniciarSesion(user, password);
            if (usuarioId == 0)
            {
                Response.Write("<script> alert(" + "'Verifique sus datos'" + ") </script>");
            }
            else
            {
                 //Session["usuarioId"] = usuarioId;
                //Response.Redirect("~/pages/inicio/sistema.aspx");
                return 
            }
        }

        protected void lnkRegistro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/registro.aspx");
        }
    }
}