using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPIwithNetCore.Models;
using MyFirstWebAPIwithNetCore.Services;

namespace MyFirstWebAPIwithNetCore.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IProductService _service;
        public ExampleController(IProductService ser)
        {
            _service = ser;
        }
        [HttpPost]
        [Route("add")]
        public ActionResult<Product> AddItem(Product pp)
        {
            var items = _service.AddItem(pp);
            if (items==null)
            {
                return NotFound();
            }
            else
            {
                return items;
            }
        }

    }
}