using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QIQO.Business.Companies.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using QIQO.Business.Companies.Data.Interfaces;
using QIQO.Business.Companies.Data;
using QIQO.Business.Companies.Model.Interfaces;
using QIQO.Business.Companies.Model.Proxies;
using Microsoft.AspNetCore.Http;
using QIQO.Business.Companies.Model.Services;

namespace QIQO.Business.Companies
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
            services.AddCors(options =>
            {
                options.AddPolicy("AnyOrigin", builder =>
                {
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            services.AddDbContext<CompanyContext>(option => option.UseSqlServer(Configuration.GetConnectionString("CompanyManagement")));
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyManager, CompanyManager>();
            services.AddTransient<ICompanyEntityService, CompanyEntityService>();
            services.AddTransient<IAddressEntityService, AddressEntityService>();
            services.AddTransient<IAddressTypeEntityService, AddressTypeEntityService>();
            services.AddTransient<IEntityTypeEntityService, EntityTypeEntityService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AnyOrigin");
            app.UseMvc();
        }
    }
}
