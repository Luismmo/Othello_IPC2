using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;

namespace Presentacion.pages.inicio
{
    public partial class  inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                VerificarSesion();
                int usuarioId = int.Parse(Session["usuarioId"].ToString());
                Usuario user = ClsUsuario.BuscarPorId(usuarioId);
                lblNombre.Text = user.nombre;
            }
            
        }

        private void VerificarSesion()
        {
            if (Session["usuarioId"] == null)
                Response.Redirect("~/Inicio.aspx");
        }
    }
}