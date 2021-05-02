using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AccountingMaterials.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using AccountingMaterials.Domain.Abstractions.Repositories;

namespace AccountingMaterials.WebAPI
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
            services.AddCors();

            services.AddControllersWithViews();

            services.AddScoped<IDebtActRepository, DebtActRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IManufacturingCostsRepository, ManufacturingCostsRepository>();
            services.AddScoped<IMaterialsRepository, MaterialsRepository>();
            services.AddScoped<IRequimentActRepository, RequimentActRepository>();
            services.AddScoped<IRequirementInvoiceRepository, RequirementInvoiceRepository>();
            services.AddScoped<ITimecardRepository, TimecardRepository>();
            services.AddScoped<IUnitRepository, UnitRepository>();
            services.AddScoped<IUseInProductionRepository, UseInProductionRepository>();
            services.AddScoped<IUseOfMaterialsRepository, UseOfMaterialsRepository>();
            services.AddScoped<IWaybillRepository, WaybillRepository>();

            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerDocument();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseOpenApi();
                app.UseSwaggerUi3();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();
            
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
            );
            
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
