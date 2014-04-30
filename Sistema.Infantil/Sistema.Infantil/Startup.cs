using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sistema.Infantil.Startup))]
namespace Sistema.Infantil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
