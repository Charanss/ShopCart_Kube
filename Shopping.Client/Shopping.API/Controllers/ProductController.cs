﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        //private readonly ProductContext _context;
        private readonly ILogger<ProductController> _logger;
        public ProductController( ILogger<ProductController> logger)
        {
            // _context = context ?? throw new ArgumentNullException(nameof(context));ProductContext context,
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet]
        public  IEnumerable<Product> Get()
        {
            return ProductContext.Products;
                //await _context
                //            .Products
                //            .Find(p => true)
                //            .ToListAsync();
        }
    }
}