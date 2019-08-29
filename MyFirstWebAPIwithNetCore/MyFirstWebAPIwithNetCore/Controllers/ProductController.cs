using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstWebAPIwithNetCore.Models;


namespace MyFirstWebAPIwithNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductContext _productContext;
        public ProductController(ProductContext productContext) => _productContext = productContext;

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProduct()
        {

            return _productContext.products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var finded = _productContext.products.Find(id);
            if (finded == null)
            {
                return NotFound();
            }
            else
            {
                return finded;
            }  
        }
        [HttpPost]
        public ActionResult<Product> PostProduct(Product pp)
        {
            _productContext.products.Add(pp);
            _productContext.SaveChanges();
            return CreatedAtAction("GetProduct", new Product { id = pp.id }, pp);
        }

        [HttpPut("{id}")]
        public ActionResult PutProduct(int id,Product pp)
        {
            if (id != pp.id) return BadRequest();
            _productContext.Entry(pp).State = EntityState.Modified;
            _productContext.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            var finded = _productContext.products.Find(id);
            if (finded == null) return NotFound();
            _productContext.products.Remove(finded);
            _productContext.SaveChanges();
            return finded;
        }

    }
}