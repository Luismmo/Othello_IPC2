using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Othello2._0.Models;


namespace Othello2._0.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IniciarSesion(string inputUser, string inputPassword) 
        {           
            try
            {
                ViewBag.Login = "";
                
                using (OthelloEntities proyecto =  new OthelloEntities())
                {
                    var lista = from datos in proyecto.Usuario
                                where datos.nombreUsuario == inputUser && datos.contrasenia.ToString() == inputPassword
                                select datos;
                    if (lista.Count() > 0)
                    {
                        Usuario usuarios = lista.First();
                        Session["usuario"] = usuarios;
                        return RedirectToAction("../Main/Main");
                    }
                    else
                    {
                        ViewBag.Login = "Verifique su nombre de Usuario y/o contraseña";
                    }
                }
                
            }
            catch (Exception e)
            {
                
            }
            return View();
        }
    }    
}