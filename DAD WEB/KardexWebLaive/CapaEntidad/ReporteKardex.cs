using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ReporteKardex
    {
        public string FechaVenta { get; set; }
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string NombreTienda { get; set; }
        public string RucTienda { get; set; }
        public string NombreEmpleado { get; set; }
        public string CantidadUnidadesVendidas { get; set; }
        public string CantidadProductos { get; set; }
        public string TotalVenta { get; set; }

           
        public string idProducto { get; set; }
        public string descripcion { get; set; }
        public decimal ingresos { get; set; }
        public decimal salidas { get; set; }
        public decimal stock { get; set; }


    }

}
