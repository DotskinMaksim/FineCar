using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FineCar.Startup))]
namespace FineCar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
