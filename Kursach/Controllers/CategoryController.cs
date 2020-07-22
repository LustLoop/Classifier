using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kursach.Models;
using Kursach.Services;

namespace Kursach.Controllers
{
    [Route("api/classifier/categories")]
    [ApiController]
    public class CategoryController : Controller
    {
        private CategoryService _categoryService;

        public CategoryController(CategoryService category)
        {
            this._categoryService = category;
        } 

        [HttpPost("post")]
        public void Add()
        {
            _categoryService.Add();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Category> products = _categoryService.GetAll();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Category category = _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
    }
}