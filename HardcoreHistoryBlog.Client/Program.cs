using Blazor.Extensions.Storage;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Sotsera.Blazor.Toaster.Core.Models;
using System.Threading.Tasks;


namespace HardcoreHistoryBlog.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddStorage();
            builder.Services.AddToaster(config =>
            {
                config.PositionClass = Defaults.Classes.Position.TopRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = false;
            });
            builder.RootComponents.Add<App>("app");
            var host = builder.Build();
            // Add component initialization, if required
            await host.RunAsync();
        }
    }
}
