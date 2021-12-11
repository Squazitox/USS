using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KardexLaiveWeb.Controllers
{
    public class ReporteController : Controller
    {
        // GET: Reporte
        public ActionResult Producto()
        {
            return View();
        }

        // GET: Reporte
        public ActionResult Ventas()
        {
            return View();
        }

        // GET: Reporte
        public ActionResult Vencimiento()
        {
            return View();
        }

        public ActionResult Kardex()
        {
            return View();
        }

        public JsonResult ObtenerProducto(int idtienda, string codigoproducto)
        {
            List<ReporteProducto> lista = CD_Reportes.Instancia.ReporteProductoTienda(idtienda, codigoproducto);

            return Json(lista, JsonRequestBehavior.AllowGet);
        }


        public JsonResult ObtenerVenta(string fechainicio, string fechafin, int idtienda)
        {
            
            List<ReporteVenta> lista = CD_Reportes.Instancia.ReporteVenta(Convert.ToDateTime(fechainicio), Convert.ToDateTime(fechafin), idtienda);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerKardex(string idProducto)
        {

            List<ReporteKardex> lista = CD_Reportes.Instancia.ReporteKardex(idProducto);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerVencimiento(string fechainicio, string fechafin)
        {

            List<ReporteVencimiento> lista = CD_Reportes.Instancia.ReporteVencimiento(Convert.ToDateTime(fechainicio), Convert.ToDateTime(fechafin));
            return Json(lista, JsonRequestBehavior.AllowGet);
        }
    }
}