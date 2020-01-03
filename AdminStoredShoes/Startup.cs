using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminStoredShoes.Startup))]
namespace AdminStoredShoes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
