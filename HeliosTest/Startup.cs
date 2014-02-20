namespace HeliosTest
{
    using System;
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // New code:
            app.Run(async context =>
            {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}
