using System.Web;
using System.Web.Mvc;
using WatchShop.Infrastructure;

namespace WatchShop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            DependencyResolver.SetResolver(new ShopDependencyResolver());
        }
    }
}
