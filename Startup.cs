using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using Microsoft.OpenApi.Models;
using SS_API.Data;
using SS_API.Repositories;
using SS_API.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace SS_API
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="env"></param>
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfigurationRoot Configuration { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<StreamerContext>(
                x => x.UseSqlite(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddMvc();
            // Configurando a injeção de dependência do service
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<ICourseService, CourseService>();
            services.AddTransient<IProjectRepository, ProjectRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();

            // Adicionando políticas CORS
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true)
                .AllowAnyOrigin()
                .AllowCredentials());
            });

            // Configurando o serviço de documentação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "STREAMER-TEST API", Version = "v1" });
               
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        /// <param name="loggerFactory"></param>
        [System.Obsolete]
        public void Configure(
            IApplicationBuilder app,
            IHostingEnvironment env,
            ILoggerFactory loggerFactory)
        {
            app.UseCors("CorsPolicy");

            // Ativando middlewares para uso do Swagger
            app.UseSwagger();
            var swaggerUrl = "/swagger/v1/swagger.json";
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint(swaggerUrl, "STREAMER-TEST API");
                c.RoutePrefix = string.Empty;
            });

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Project}/{action=GetAll}");
            });
            
        }
    }
}
