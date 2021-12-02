using System.Web;
using System.Web.Mvc;
using KardexLaiveWeb.Filters;
namespace KardexLaiveWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new VerificarSession());
        }
    }
}
