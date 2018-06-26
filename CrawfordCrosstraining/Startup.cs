using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(CrawfordCrosstraining.Startup))]
namespace CrawfordCrosstraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
            ConfigureAuth(app);
        }
    }
}
