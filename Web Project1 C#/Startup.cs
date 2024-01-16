using Microsoft.Extensions.DependencyInjection;

namespace Web_Project1_C_
{

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response
                    .WriteAsync("Jello World");
            });
        }
    }

}
