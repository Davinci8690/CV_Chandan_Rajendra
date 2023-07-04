using System.Web;
using System.Web.Mvc;

namespace CV_Chandan_Rajendra
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
