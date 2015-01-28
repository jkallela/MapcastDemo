using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MapcastDemo.Startup))]
namespace MapcastDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
