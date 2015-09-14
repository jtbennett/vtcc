using Microsoft.AspNet.Builder;

namespace VtccDemo
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseWelcomePage();
        }
    }
}
