using Microsoft.AspNetCore.Mvc;
using KidzplaygroundAPI.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using KidzplaygroundAPI.DAL;

namespace KidzplaygroundApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryManager _category;

        public CategoryController(CategoryManager category)
        {
            _category = category;
        }


        [HttpGet]
        public async Task<IEnumerable<Category>> GetAsync()
        {
            var category = await _category.GetCategories();
            return category;
        }


    }
}
