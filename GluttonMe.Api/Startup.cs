using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GluttonMe.Api.Interfaces;
using GluttonMe.Api.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace GluttonMe.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpsRedirection(serv => serv.HttpsPort = 3001);

            services.AddCors(cfg => cfg.AddPolicy("", new CorsPolicy()));
            
            services.Configure<GluttonMeDatabaseSettings>(Configuration.GetSection(nameof(GluttonMeDatabaseSettings)));

            services.AddSingleton<IGluttonMeDatabaseSettings>(sp => 
            sp.GetRequiredService<IOptions<GluttonMeDatabaseSettings>>().Value);

            //TODO - New to add DatabaseInit Service and use DatabaseSettings properly
            services.AddSingleton<GluttonMeDatabaseInitializer>();

            
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(cfg =>
                {
                    cfg.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            }
            else
            {
                app.UseCors(cfg =>
                {
                    cfg.WithOrigins("")
                    .AllowAnyMethod();
                });
                app.UseHttpsRedirection();

                app.UseRouting();

                app.UseAuthorization();

            }
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
