using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Title { get; set; }

        public string Imagepath { get; set; }

        public int CateogaryID { get; set; }

        public double Price { get; set; }



        // Relations

        public Cateogary Cateogary { get; set; }
    }
}
