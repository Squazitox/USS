using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        //public int IdVenta { get; set; }
        //public string TipoDocumento { get; set; }
        //public string Codigo { get; set; }
        //public float TotalCosto { get; set; }
        //public string TextoTotalCosto { get; set; }
        //public float ImporteRecibido { get; set; }
        //public string TextoImporteRecibido { get; set; }
        //public float ImporteCambio { get; set; }
        //public string TextoImporteCambio { get; set; }
        //public string FechaRegistro { get; set; }
        //public DateTime VFechaRegistro { get; set; }
        public Usuario oUsuario { get; set; }
        //public Tienda oTienda { get; set; }
        //public Cliente oCliente { get; set; }
        //public List<DetalleVenta> oListaDetalleVenta { get; set; }

        public String idProducto { get; set; }
        public String descripcion { get; set; }
        public String lote { get; set; }
        public String seccion { get; set; }
        public DateTime caducidad { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string idTrabajador { get; set; }
        public String idDespacha { get; set; }
        public string idUbicacion { get; set; }
        public string planta { get; set; }
        public string Ubicacion { get; set; }
        public string cantidad { get; set; }




    }
}
