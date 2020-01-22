using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jp267815MIS4200.Startup))]
namespace jp267815MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
