using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    public class Menu
    {
        //public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public List<SubMenu> oSubMenu { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }


        public int idMenu { get; set; }
        public string nombreMenu { get; set; }
        public string nombreInterno { get; set; }
        public string estado { get; set; }
        public int padre { get; set; }
        public string nombreVista { get; set; }




    }
}
