using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Cateogary
    {
        public int CateogaryID { get; set; }

        public string Title { get; set; }

        public string Imagepath { get; set; }




        //Relations

        public ICollection<Product> Products { get; set; }

    }
}
