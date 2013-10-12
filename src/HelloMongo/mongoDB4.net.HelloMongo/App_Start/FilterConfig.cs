using System.Web;
using System.Web.Mvc;

namespace mongoDB4.net.HelloMongo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}