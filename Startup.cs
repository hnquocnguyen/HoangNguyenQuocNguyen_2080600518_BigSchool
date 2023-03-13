using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HoangNguyenQuocNguyen_2080600518_BigSchool.Startup))]
namespace HoangNguyenQuocNguyen_2080600518_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
