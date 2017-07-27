using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConcertEvents.Startup))]
namespace ConcertEvents
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
