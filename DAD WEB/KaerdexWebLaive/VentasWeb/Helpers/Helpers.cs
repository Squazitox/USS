using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace KardexLaiveWeb.Helpers
{
    public static class Helpers
    {
        public static MvcHtmlString ActionLinkAllow(this HtmlHelper helper)
        {

            StringBuilder sb = new StringBuilder();

            if (HttpContext.Current.Session["Usuario"] != null)
            {

                Usuario oUsuario = (Usuario)HttpContext.Current.Session["Usuario"];

                //Usuario rptUsuario = CD_Usuario.Instancia.ObtenerDetalleUsuario(oUsuario.IdUsuario);
                List<Menu> rptMenu = CD_Usuario.Instancia.ObtenerDetalleUsuario_Menu(oUsuario.idTipoUsuario);
                var listMenu = rptMenu.Where(x => x.nombreInterno == "#").ToList();
                //var listMenutrab = rptMenu 

                int contador = 1;
                string valorIngles = string.Empty;

                foreach (Menu item in listMenu)
                {


                    if (contador == 1) {
                        valorIngles = "One";
                    } else if ( contador == 2)
                    {
                        valorIngles = "Two";
                    }
                    else if (contador == 3)
                    {
                        valorIngles = "Three";
                    }

                    sb.AppendLine("<li class='accordion'>");
                    sb.AppendLine("<a href = '#' data-bs-toggle='collapse' data-bs-target='#collapse" + valorIngles+"' aria-expanded='false' aria-controls='collapse"+valorIngles+"' class='collapsible'>");
                    sb.AppendLine("<span class='icon-home mr-3'></span>" + item.nombreMenu + " ");
                            sb.AppendLine("</a>");
                            sb.AppendLine("<div id='collapse"+valorIngles+"'  class='collapse' aria-labelledby='heading"+valorIngles+"'>");
                                sb.AppendLine("<div>");
                                    sb.AppendLine("<ul>");

                    var rptSubMenu = rptMenu.Where(x => x.nombreInterno != "#").Where(y => y.padre == item.padre).ToList();
                                        foreach (Menu subitem in rptSubMenu) {
                                            sb.AppendLine("<li><a href = '/" + subitem.nombreInterno + "/" + subitem.nombreVista + "' > "+ subitem.nombreMenu+" </a></li> ");
                                        }
                                
                                       
                                    sb.AppendLine("</ul>");
                                sb.AppendLine("</div>");
                    sb.AppendLine("</div>");
                    sb.AppendLine("</li>");

                    contador++;


                    //sb.AppendLine("<li class='nav-item dropdown'>");
                    //sb.AppendLine("<a class='nav-link dropdown-toggle' href='#' data-toggle='dropdown'><i class='" + "" +"'></i> " + item.nombreMenu + "</a>");

                    //sb.AppendLine("<div class='dropdown-menu drop-menu'>");

                    //var rptSubMenu = rptMenu.Where(x => x.nombreInterno != "#").Where(y => y.padre == item.padre).ToList();

                    //foreach (Menu subitem in rptSubMenu)
                    //{
                    //    //fas fa-caret-right
                    //    if(subitem.estado == "A")
                    //        sb.AppendLine("<a class='dropdown-item' name='" + subitem.nombreMenu + "' href='/" + subitem.nombreInterno + "/" + subitem.nombreVista + "'><i class='" + "Ic" + "'></i> " + subitem.nombreMenu + "</a>");

                    //}
                    //sb.AppendLine("</div>");

                    //sb.AppendLine("</li>");
                }


            }


            return new MvcHtmlString(sb.ToString());
        }

    }
}