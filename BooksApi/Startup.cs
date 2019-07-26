using System;
using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace BooksApi
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
            services.Configure<BookstoreDatabaseSettings>(
       Configuration.GetSection(nameof(BookstoreDatabaseSettings)));

            services.AddSingleton<IBookstoreDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<BookstoreDatabaseSettings>>().Value);

            services.AddSingleton<BookService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(
                            c =>
                            {
                                c.SwaggerDoc("v1", new OpenApiInfo
                                {
                                    Version = "v1",
                                    Title = "Documentação API Eventos Swagger",
                                    Description = "A simple example ASP.NET Core Web API",
                                    TermsOfService = new Uri("https://example.com/terms"),
                                    Contact = new OpenApiContact
                                    {
                                        Name = "Shayne Boyer",
                                        Email = string.Empty,
                                        Url = new Uri("https://twitter.com/spboyer"),
                                    },
                                    License = new OpenApiLicense
                                    {
                                        Name = "Use under LICX",
                                        Url = new Uri("https://example.com/license"),
                                    }
                                });
                            });

            services.AddCors();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseSwagger();
            app.UseSwaggerUI(
                c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1.0");
                }
                );
            var option = new RewriteOptions();
            option.AddRedirect("^$", "swagger");
            app.UseRewriter(option);
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
