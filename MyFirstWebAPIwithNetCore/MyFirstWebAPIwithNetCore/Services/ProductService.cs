using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstWebAPIwithNetCore.Models;

namespace MyFirstWebAPIwithNetCore.Services
{
    public class ProductService : IProductService
    {
        private readonly Dictionary<string, Product> _proItems;
        public ProductService()
        {
            _proItems = new Dictionary<string, Product>();
        }
        public Product AddItem(Product pp)
        {
            _proItems.Add(pp.p_name,pp);
            
           


            return pp;
        }
    }
}
