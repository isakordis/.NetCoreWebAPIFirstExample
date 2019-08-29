using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFirstWebAPIwithNetCore.Models;

namespace MyFirstWebAPIwithNetCore.Services
{
    public interface IProductService
    {
        Product AddItem(Product pp);
    }
}
