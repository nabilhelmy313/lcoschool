using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TasksProject.Startup))]
namespace TasksProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
