using System;
using System.IO;
using System.Reflection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using ProductData;
using ProductData.IRepository;
using ProductData.Repository;
using ProductData.Entity.Mapper;

namespace ProductCatalog.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddCors();

            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Win10DB")));
            //services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddAutoMapper(typeof(ProductMapper));
            //services.Add(typeof(ProductMapper));

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("Product",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "Product API",
                        Version = "1"
                    });

                var xmlCommentFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var cmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentFile);
                options.IncludeXmlComments(cmlCommentsFullPath);
            });

            return services;
        }
    }
}
