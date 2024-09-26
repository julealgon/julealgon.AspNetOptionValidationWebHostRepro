namespace julealgon.AspNetOptionValidationWebHostRepro;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

public static class Program
{
    public static void Main(string[] args)
    {
        using var host = WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();

        host.Run();
    }
}
