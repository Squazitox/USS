using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KardexLaiveWeb.Utilidades;

namespace KardexLaiveWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string usuario, string clave)
        {

            Usuario ousuario = CD_Usuario.Instancia.ObtenerUsuarios().Where(u => u.NombreUsuario == usuario && u.Clave == clave ).FirstOrDefault();

            if (ousuario == null)
            {
                ViewBag.Error = "Usuario o contraseña no correcta";
                return View();
            }

            Session["Usuario"] = ousuario;

            return RedirectToAction("Home", "Home");
        }
    }
}