

using Back.Interview.Domain.Repositories;
using Back.Interview.Repository.Repositories.DataInterview;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;

namespace Back.Interview.Tests
{
    public class CustomWebApplicationFactory : WebApplicationFactory<Program>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                // Remova o repositório existente
                var descriptor = services.SingleOrDefault(
                    d => d.ServiceType == typeof(IDataInterviewRepository));
                if (descriptor != null)
                {
                    services.Remove(descriptor);
                }

                // Adicione um repositório mockado
                services.AddScoped<IDataInterviewRepository, DataInterviewRepository>();
            });
        }
    }
}