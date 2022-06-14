using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NorthwindApp.Api.Domain.Interfaces;
using NorthwindApp.Api.Domain.Mappers;
using NorthwindApp.Api.Domain.Services;
using NorthwindApp.Infrastructure.Api.Context;
using NorthwindApp.Infrastructure.Api.Filters;
using NorthwindApp.Infrastructure.Api.Repositories;
using NorthwindApp.Infrastructure.Api.Repositories.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace NorthwindApp.Api
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
            //services.AddAutoMapper(typeof(Startup), typeof(AutomapperProfile));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //services.AddMvc(options => options.Filters.Add<ValidationFilter>())
            //    .AddFluentValidation(options =>
            //        options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            //services.AddControllers();
            services.AddControllers(options =>
            {
                options.Filters.Add<ValidationFilter>();
            }).AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            })
                .AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            services.AddDbContext<NorthwindContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConnectionDB")));

            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IOrderDetailService, OrderDetailService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRegionService, RegionService>();
            services.AddScoped<IShipperService, ShipperService>();
            services.AddScoped<ISupplierService, SupplierService>();
            services.AddScoped<ITerritoryService, TerritoryService>();

            

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NorthwindApp.Api", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NorthwindApp.Api v1"));
            }

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
