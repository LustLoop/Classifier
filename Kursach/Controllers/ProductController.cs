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

        [HttpPost]
        public void AddNewProduct()
        {
            _productService.AddProduct();
        }
    }
}

