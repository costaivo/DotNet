using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoApp.Startup))]
namespace TodoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
