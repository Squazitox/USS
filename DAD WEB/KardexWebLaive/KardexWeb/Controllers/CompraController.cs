using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace KardexLaiveWeb.Controllers
{
    public class CompraController : Controller
    {
        private static Usuario SesionUsuario;
        // GET: Compra
        public ActionResult Crear()
        {
            SesionUsuario = (Usuario)Session["Usuario"];
            return View();
        }
        // GET: Compra
        public ActionResult Consultar()
        {
            return View();
        }

        public ActionResult Documento(int idcompra = 0) {
            
            Compra oCompra = CD_Compra.Instancia.ObtenerDetalleCompra(idcompra);

            if (oCompra == null) {
                oCompra = new Compra();
            }


            return View(oCompra);
        }


        public JsonResult Obtener(string fechainicio, string fechafin, int idproveedor, int idtienda)
        {
            List<Compra> lista = CD_Compra.Instancia.ObtenerListaCompra(Convert.ToDateTime(fechainicio), Convert.ToDateTime(fechafin), idproveedor, idtienda);
            return Json(new { data = lista }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult Guardar(string dataAll)
        {
            //xml = xml.Replace("!idusuario¡", SesionUsuario.IdUsuario.ToString());
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {

                    var data = new JavaScriptSerializer().Deserialize<List<Compra>>(dataAll);

                    foreach (var item in data)
                    {
                        CD_Compra.Instancia.RegistrarCompra(item);
                    }

                    scope.Complete();

                    //bool respuesta = CD_Compra.Instancia.RegistrarCompra(dataAll);
                    //bool respuesta  = true;

                    return Json(new { resultado = true }, JsonRequestBehavior.AllowGet);

                }
            }
            catch (Exception)
            {

                return Json(new { resultado = false }, JsonRequestBehavior.AllowGet);
            }
            
                
        }



    }
}