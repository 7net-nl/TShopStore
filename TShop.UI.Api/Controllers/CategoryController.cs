using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TShop.Service.Application.Categorys;

namespace TShop.UI.Api.Controllers
{
    [Route("api/v{version:apiversion}/Category")]
    [ApiController]
    [EnableCors("HealthPolicy")]
    [ApiVersion("1.0")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        
        [HttpGet]
        public IEnumerable<CategoryDto> Get()
        {
            return categoryService.GetAll();
        }

    }
}
