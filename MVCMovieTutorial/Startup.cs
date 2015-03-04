using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMovieTutorial.Startup))]
namespace MVCMovieTutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
