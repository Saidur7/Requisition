using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Requisition.Startup))]
namespace Requisition
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
