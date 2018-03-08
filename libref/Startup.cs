using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(libref.Startup))]
namespace libref
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
