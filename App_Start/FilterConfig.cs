using System.Web;
using System.Web.Mvc;

namespace HoangNguyenQuocNguyen_2080600518_BigSchool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
