using AutoMapper;
using Base.Application.Service.Interfaces.Contracts.Seguridad;
using Base.Application.Services.Interfaces.Implementacion.Seguridad;
using Base.Application.Services.Mapeo;
using Base.Infraestructura.Data.Repositorios.Contrato.Seguridad;
using Base.Infraestructura.Data.Repositorios.Implementacion.Seguridad;
using Base.Infraestructura.Datos.ContextoBD;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Base.Application.Services.RegistroServicios
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            DotNetEnv.Env.Load();

            string connectionString = DotNetEnv.Env.GetString("DefaultConnection");

            configuration["ConnectionStrings:DefaultConnection"] = connectionString != null ? connectionString : configuration.GetConnectionString("DefaultConnection");

            #region DataBaseConnection
            services.AddDbContext<DataBaseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
            #endregion

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToDtoMappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            AddServices(services);
            AddRepository(services);


            return services;
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<IUserAccountService, UserAccountService>();
        }

        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
        }
    }
}
