using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenQuangAnh_Lab456.Startup))]
namespace NguyenQuangAnh_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
