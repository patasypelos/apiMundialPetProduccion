using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MundialApiPet.Modelo;
using MundialApiPet.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static MundialApiPet.Modelo.Context;

namespace MundialApiPet
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
            services.AddControllers();

            // Agregar el contexto de la base de datos y configurar la cadena de conexión
            services.AddDbContext<Context>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<RepositorioInversiones>();
            services.AddScoped<RepositorioInventario>();
            services.AddScoped<RepositorioVentas>();
            services.AddScoped<RepositorioiRegistrarUsuariosMascotas>();
            services.AddScoped<RepositorioUsuarioAdministracion>();
            services.AddScoped<RepositorioProductosServicos>();

            services.Configure<FormOptions>(options =>
            {
                options.MultipartBodyLengthLimit = 100000000000000000; // Cambia esto al tamaño máximo que deseas permitir
            });

            //services.AddCors(options =>
            //{



            //    options.AddDefaultPolicy(builder =>
            //    {
            //        builder.WithOrigins("http://localhost:3000",
            //                            "http://localhost:3001",
            //                            "http://localhost:3002",
            //                            "http://localhost:3003",
            //                            "http://192.168.20.47:3000",
            //                            "http://192.168.20.47:3000"
            //                            ) 


            //               .AllowAnyMethod()
            //               .AllowAnyHeader();
            //    });

            //});

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAnyOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Middleware para habilitar CORS
            app.UseCors("AllowAllOrigins");

            app.UseCors(options =>
            {
                options.WithOrigins("http://192.168.20.47",
                                    "http://localhost:3000",
                                    "http://localhost:3001",
                                    "http://localhost:3002",
                                    "http://localhost:3002"
                    )
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });

            app.UseStaticFiles();

            // Servir archivos desde la carpeta "Documentos" en la raíz del proyecto
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(env.ContentRootPath, "Documentos")),
                RequestPath = "/Documentos"
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
