using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppGetDemo.Startup))]
namespace WebAppGetDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
