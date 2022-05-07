﻿using Microsoft.EntityFrameworkCore;
using ProjectManagement.Contracts.Utilities.Logger;
using ProjectManagement.Logger.NLog;
using ProjectManagement.Repository;

namespace ProjectManagement.WebApi.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerService, LoggerService>();
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RepositoryContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("sqlConnection"),
                    project => project.MigrationsAssembly("ProjectManagement.Repository")
                )
            );
        }
    }
}