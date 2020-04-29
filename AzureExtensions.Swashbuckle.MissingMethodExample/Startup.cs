using System.Reflection;
using AzureExtensions.Swashbuckle.MissingMethodExample;
using AzureFunctions.Extensions.Swashbuckle;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Azure.WebJobs;

[assembly: FunctionsStartup(typeof(Startup))]
namespace AzureExtensions.Swashbuckle.MissingMethodExample
{
    /// <summary>
    /// Startup class.
    /// </summary>
    public class Startup : FunctionsStartup
    {
        /// <summary>
        /// Configure method.
        /// </summary>
        /// <param name="builder"></param>
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddWebJobs(c => c.AllowPartialHostStartup = false).AddSwashBuckle(Assembly.GetExecutingAssembly());
        }
    }
}
