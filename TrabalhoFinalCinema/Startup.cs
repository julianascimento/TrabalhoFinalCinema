using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrabalhoFinalCinema.Startup))]
namespace TrabalhoFinalCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
