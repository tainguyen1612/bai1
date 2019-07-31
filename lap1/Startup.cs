using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lap1.Startup))]
namespace lap1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
