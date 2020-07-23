using System.Web;
using System.Web.Mvc;

namespace Final_DiazRuiz_Calidad
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
