using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Presentacion.resources.master
{
    public partial class plantilla : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuarioId"] != null)
            {
                int usuarioId = int.Parse(Session["usuarioId"].ToString());
                Usuario user = ClsUsuario.BuscarPorId(usuarioId);
                lblNombre.Text = user.nombre;
            }
            else
            {
                Response.Redirect("~/Inicio.aspx");
            }
                
             
        }

        protected void linkCerrrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Inicio.aspx");
        }
    }
}