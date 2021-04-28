using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TShop.Service.Application;
using TShop.Service.Application.Products;

namespace TShop.UI.Api.Controllers
{
    [Route("api/v{version:apiversion}/Store")]
    [ApiController]
    [EnableCors("HealthPolicy")]
    [ApiVersion("1.0")]
    public class StoreController : ControllerBase
    {
        private readonly IProductService productService;

        public StoreController(IProductService productService)
        {
            this.productService = productService;
        }
        
        [HttpGet("GetAll")]
        public ActionResult<List<ProductDto>> GetAll(string Brand="",string Category="",string Color="",int MaxPrice=0,int MinPrice=0,short SelectPage=1,short ShowPage=6,short TotalPage=0)
        {
           
            var Pagination = productService.Pagination(new Paging
            {
                 Brand=Brand,
                 Category=Category,
                 Color=Color,
                 MaxPrice=MaxPrice,
                 MinPrice=MinPrice,
                 SelectPage=SelectPage,
                 ShowPage=ShowPage,
                 TotalPage=TotalPage

            });

            return productService.GetAll(Pagination);
        }

        [HttpGet("GetAllInclude")]
        public ActionResult<List<ProductDto>> GetAllInclude(string Brand = "", string Category = "", string Color = "", int MaxPrice = 0, int MinPrice = 0, short SelectPage = 1, short ShowPage = 6, short TotalPage = 0)
        {

            var Pagination = productService.Pagination(new Paging
            {
                Brand = Brand,
                Category = Category,
                Color = Color,
                MaxPrice = MaxPrice,
                MinPrice = MinPrice,
                SelectPage = SelectPage,
                ShowPage = ShowPage,
                TotalPage = TotalPage

            });

            return productService.GetAllInclude(Pagination);
        }


        [HttpGet("Find")]
        public ActionResult<ProductDto> Find(long Id)
        {
            return productService.Find(Id);
        }

        [HttpGet("FindInclude")]
        public ActionResult<ProductDto> FindInclude(long Id)
        {
            return productService.FindInclude(Id);
        }

    }
}
