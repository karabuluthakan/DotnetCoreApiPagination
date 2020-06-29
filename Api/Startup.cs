using System;
using Api.Business;
using Api.Business.Abstract;
using Api.DataAccess.Abstract;
using Api.DataAccess.EntityFramework;
using Api.DataAccess.EntityFramework.Persistence;
using Api.Utilities.AppSettings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private const string CorsPolicy = "AllowAllCorsPolicy";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddHttpContextAccessor();
            services.AddSingleton<IPaginationUriService>(opt =>
            {
                var httpContextAccessor = opt.GetRequiredService<IHttpContextAccessor>();
                return new PaginationUriManager(httpContextAccessor);
            });
            services.AddEntityFrameworkSqlite().AddDbContext<GeolocationDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("DefaultDatabaseConnection"));
            });
            services.AddScoped<ICityRepository, EfCityRepository>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IContinentalRepository, EfContinentalRepository>();
            services.AddScoped<IContinentalService, ContinentalManager>();
            services.AddScoped<ICountryRepository, EfCountryRepository>();
            services.AddScoped<ICountryService, CountryManager>();
            services.AddScoped<IRegionRepository, EfRegionRepository>();
            services.AddScoped<IRegionService, RegionManager>();
            services.AddCors(options =>
            {
                options.AddPolicy(CorsPolicy,
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .SetPreflightMaxAge(TimeSpan.FromSeconds(86400))
                        .WithExposedHeaders("WWW-Authenticate"));
            });
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Api Pagination",
                        Version = "v1",
                        Description = "Dotnet Core Api Pagination",
                        Contact = new OpenApiContact
                        {
                            Name = "Hakan Karabulut",
                            Url = new Uri("https://github.com/karabuluthakan")
                        },
                        License = new OpenApiLicense
                        {
                            Name = "The MIT License",
                            Url = new Uri("https://opensource.org/licenses/MIT")
                        },
                        TermsOfService = new Uri("https://smartbear.com/terms-of-use/")
                    });
            });
            services.AddControllers();
        } 
        
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(CorsPolicy);

            app.UseHttpsRedirection();

            app.UseRouting();

            var swaggerSettings = new SwaggerSettings();
            Configuration.GetSection(nameof(SwaggerSettings)).Bind(swaggerSettings);
            app.UseSwagger(opt => { opt.RouteTemplate = swaggerSettings.JsonRoute; });
            app.UseSwaggerUI(opt => { opt.SwaggerEndpoint(swaggerSettings.UiEndpoint, swaggerSettings.Description); });

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}