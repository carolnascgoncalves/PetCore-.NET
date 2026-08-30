using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PetCore.Infrastructure.Persistence;

namespace PetCore.Tests.Integration;

public sealed class PetCoreApiFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Testing");
        builder.ConfigureServices(services =>
        {
            var descriptors = services.Where(descriptor =>
                descriptor.ServiceType == typeof(DbContextOptions<PetCoreContext>) ||
                descriptor.ServiceType == typeof(PetCoreContext)).ToList();

            foreach (var descriptor in descriptors)
                services.Remove(descriptor);

            services.AddDbContext<PetCoreContext>(options =>
                options.UseInMemoryDatabase("PetCoreIntegrationTests"));
        });
    }
}
