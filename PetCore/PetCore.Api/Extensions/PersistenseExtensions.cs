using Microsoft.EntityFrameworkCore;
using PetCore.Application.Interfaces;
using PetCore.Application.Services.Implementations;
using PetCore.Application.Services.Interfaces;
using PetCore.Infrastructure.Persistence;

namespace PetCore.Extensions;

public static class PersistenceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IClinicaService, ClinicaService>();
        services.AddScoped<IEnderecoService, EnderecoService>();
        services.AddScoped<IExameService, ExameService>();
        services.AddScoped<IHistoricoService, HistoricoService>();
        services.AddScoped<IMedicamentoService, MedicamentoService>();
        services.AddScoped<IMedicoService, MedicoService>();
        services.AddScoped<IPetService, PetService>();
        services.AddScoped<IProntuarioService, ProntuarioService>();
        services.AddScoped<IReceitaService, ReceitaService>();
        services.AddScoped<IRelatorioService, RelatorioService>();
        services.AddScoped<ITutorService, TutorService>();

        return services;
    }

    /*
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        services.AddScoped<IClinicaService, ClinicaService>();
        services.AddScoped<IEnderecoService, EnderecoService>();
        services.AddScoped<IExameService, ExameService>();
        services.AddScoped<IHistoricoService, HistoricoService>();
        services.AddScoped<IMedicamentoService, MedicamentoService>();
        services.AddScoped<IMedicoService, MedicoService>();
        services.AddScoped<IPetService, PetService>();
        services.AddScoped<IProntuarioService, ProntuarioService>();
        services.AddScoped<IReceitaService, ReceitaService>();
        services.AddScoped<IRelatorioService, RelatorioService>();
        services.AddScoped<ITutorService, TutorService>();
        return services;
    }


    public static IServiceCollection AddDBContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PetCoreContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("PetCoreMySql");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });
        return services;
    }*/
}