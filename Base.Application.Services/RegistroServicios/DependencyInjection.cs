using AutoMapper;
using Base.Application.Service.Interfaces.Contracts.Seguridad;
using Base.Application.Services.Interfaces.Contrato.Grupos;
using Base.Application.Services.Interfaces.Contrato.Grupos.Clases;
using Base.Application.Services.Interfaces.Contrato.Periodos;
using Base.Application.Services.Interfaces.Contrato.Personas;
using Base.Application.Services.Interfaces.Implementacion.Grupos;
using Base.Application.Services.Interfaces.Implementacion.Grupos.Clases;
using Base.Application.Services.Interfaces.Implementacion.Periodos;
using Base.Application.Services.Interfaces.Implementacion.Personas;
using Base.Application.Services.Interfaces.Implementacion.Seguridad;
using Base.Application.Services.Mapeo;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos;
using Base.Infraestructura.Data.Repositorios.Contrato.Grupos.Clases;
using Base.Infraestructura.Data.Repositorios.Contrato.Periodos;
using Base.Infraestructura.Data.Repositorios.Contrato.Personas;
using Base.Infraestructura.Data.Repositorios.Contrato.Seguridad;
using Base.Infraestructura.Data.Repositorios.Implementacion.Grupos;
using Base.Infraestructura.Data.Repositorios.Implementacion.Grupos.Clases;
using Base.Infraestructura.Data.Repositorios.Implementacion.Periodos;
using Base.Infraestructura.Data.Repositorios.Implementacion.Personas;
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
            services.AddScoped<IAlumnosServices, AlumnoServices>();
            services.AddScoped<IPersonaServices, PersonaServices>();
            services.AddScoped<IProfesorServices, ProfesorServices>();
            services.AddScoped<IPeriodosServices, PeriodosServices>();
            services.AddScoped<IGrupoServices, GrupoServices>();
            services.AddScoped<IGruposAlumnosServices, GruposAlumnosServices>();
            services.AddScoped<IGrupoPeriodosServices, GruposPeriodosServices>();
            services.AddScoped<IUnidadesServices, UnidadesServices>();
            services.AddScoped<IMateriasServices, MateriasServices>();
            services.AddScoped<IUnidadesMateriasServices, UnidadesMateriasServices>();
        }

        private static void AddRepository(IServiceCollection services)
        {
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IAlumnoRepository, AlumnoRepository>();
            services.AddScoped<IPersonaRepository, PersonaRepository>();
            services.AddScoped<IProfesorRepository, ProfesorRepository>();
            services.AddScoped<IPeriodosRepository, PeriodosRepository>();
            services.AddScoped<IGruposRepository, GruposRepository>();
            services.AddScoped<IGruposAlumnosRepository, GruposAlumnosRepository>();
            services.AddScoped<IGruposPeriodosRepository, GruposPeriodosRepository>();
            services.AddScoped<IUnidadesRepository, UnidadesRepository>();
            services.AddScoped<IMateriasRepository, MateriasRepository>();
            services.AddScoped<IUnidadesMateriasRepository, UnidadesMateriasRepository>();

        }
    }
}
