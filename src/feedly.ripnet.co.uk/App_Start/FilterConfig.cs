using System.Web;
using System.Web.Mvc;

namespace feedly.ripnet.co.uk
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}