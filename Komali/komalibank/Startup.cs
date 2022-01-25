using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(komalibank.Startup))]
namespace komalibank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
