namespace julealgon.AspNetOptionValidationWebHostRepro;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public sealed class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services
            .ConfigureOptions<MyOptionsValidator>()
            .AddOptions<MyOptions>()
            .ValidateOnStart();

        services.AddMvc();
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseMvc();
    }
}
