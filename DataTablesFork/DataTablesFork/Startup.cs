using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataTablesFork.Startup))]
namespace DataTablesFork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {            
        }
    }
}
