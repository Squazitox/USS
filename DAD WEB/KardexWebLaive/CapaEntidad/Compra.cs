using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        //public int IdCompra { get; set; }
        //public string Codigo { get; set; }
        //public string FechaCompra { get; set; }
        //public string NumeroCompra { get; set; }
        //public Usuario oUsuario { get; set; }
        //public Proveedor oProveedor { get; set; }
        //public Tienda oTienda { get; set; }
        //public List<DetalleCompra> oListaDetalleCompra { get; set; }
        //public decimal TotalCosto { get; set; }
        //public string TipoComprobante { get; set; }
        //public bool Activo { get; set; }
        //public DateTime FechaRegistro { get; set; }

        public string idSuministra { get; set; }
        public string idProveedor { get; set; }
        public string idProducto { get; set; }
        public string idUbicacion { get; set; }
        public string lote { get; set; }
        public int cantidad { get; set; }
        public string numFactura { get; set; }
        public string paisOrigen { get; set; }
        public float precio_compra { get; set; }
        public DateTime caducidad { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string razonsocial { get; set; }
        public string planta { get; set; }
        public string Ubicacion { get; set; }



    }
}
