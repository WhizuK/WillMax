using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WillMax.Applicatio.Service.Contracts;
using WillMax.Applicatio.Service.Service;
using WillMax.Domain;
using WillMax.Infra.Dta;
using WillMax.Infra.Dta.Repository;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using AutoMapper;
using WillMax.Applicatio.Service.DTos;


namespace WillMax.Infra.Data.IoC
{
    public static class DependencyContainer
    {
        public static void AddWebApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDataProtectionService, DataProtectionService>();
            services.AddScoped<ITokenService, TokenService>();


            services.AddScoped<IApartamentRepository, ApartmentRepository>();
            services.AddScoped<IApartamentService, ApartmentService>();


            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();


            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();



            services.AddScoped<DbContext, ApplicationDbContext>();

            services.AddWillMaxDatabase(configuration);


            services.AddJwtAuthentication(configuration);

            services.AddAutoMapperDependency(configuration);

        }

        public static IServiceCollection AddWillMaxDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("WillMaxCS");
                options.UseSqlServer(connectionString, x => x.MigrationsAssembly("WillMax.Services.WebApi").MigrationsHistoryTable("__EFMigrationsHistory_Data"));
            });
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"); 
            return services;
        }

        public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDataProtectionService, DataProtectionService>();
            services.AddScoped<ITokenService, TokenService>();

            services.AddAuthentication()
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = configuration["JwtSettings:Issuer"]!,
                        ValidateAudience = true,
                        ValidAudience = configuration["JwtSettings:Audience"]!,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]!)),
                    };
                });

            return services;
        }

        public static IServiceCollection AddAutoMapperDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            return services;
        }

        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                CreateMap<Apartament, ApartmentRequestDto>();
                CreateMap<ApartmentRequestDto, Apartament>();
                CreateMap<Location, LocationResponseDto>();
                CreateMap<LocationResponseDto, Location>();
            }
        }
    }
}
