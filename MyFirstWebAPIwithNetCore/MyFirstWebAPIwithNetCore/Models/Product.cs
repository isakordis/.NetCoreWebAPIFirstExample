using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebAPIwithNetCore.Models
{
    public class Product
    {
        public int id { get; set; }
        public string p_name { get; set; }
        public string p_cate { get; set; }
        public int p_price { get; set; }


    }
}
