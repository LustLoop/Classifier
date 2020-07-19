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
    [Route("api/classifier")]
    [ApiController]
    public class ProductController : Controller
    {
        private ProductService _productService;

        public ProductController(ProductService product)
        {
            this._productService = product;
        } 

        [HttpPost("post/{typeId}")]
        public void AddNewProduct(int typeId, string model, int purposeId, int qualityId, int year, string name, double price)
        {

            _productService.AddProduct(typeId, "model", purposeId, qualityId, 2001, "random name", price);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = _productService.GetAll();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

