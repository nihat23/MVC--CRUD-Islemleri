using System.Web;
using System.Web.Mvc;

namespace MVC__CRUD_Islemleri
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
