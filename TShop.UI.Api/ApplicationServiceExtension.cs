using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TShop.Domain.Contract.Interfaces;
using TShop.Domain.Contract.Repositories;
using TShop.Infrascture.DataBase.EF;
using TShop.Infrascture.DataBase.EF.Repositories;
using TShop.Service.Application;
using TShop.Service.Application.Categorys;
using TShop.Service.Application.ImageFiles;
using TShop.Service.Application.ProductColors;
using TShop.Service.Application.Products;
using TShop.Service.Application.ProductSizes;

namespace TShop.UI.Api
{
    public static class ApplicationServiceExtension
    {
        public static void AddApplicationService(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository), typeof(BaseRepository));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductColorService, ProductcolorService>();
            services.AddScoped<IImageFileService, ImageFileService>();
            services.AddScoped<IProductSizeService, ProductSizeService>();
        }
    }
}
