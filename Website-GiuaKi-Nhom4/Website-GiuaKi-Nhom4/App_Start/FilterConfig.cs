using System.Web;
using System.Web.Mvc;

namespace Website_GiuaKi_Nhom4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
