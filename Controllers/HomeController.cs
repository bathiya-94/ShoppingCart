using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShoppingContext _context;

        public HomeController(ShoppingContext context)
        {
            _context = context;
        }

        // GET: Cateogaries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cateogaries.ToListAsync());
        }

        // GET: Cateogaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cateogary = await _context.Cateogaries.Include(m => m.Products)
                .SingleOrDefaultAsync(m => m.CateogaryID == id);


            if (cateogary == null)
            {
                return NotFound();
            }

            return View(cateogary);
        }

        // GET: Cateogaries/View/5
        public async Task<IActionResult> View(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .SingleOrDefaultAsync(m => m.ProductID == id);


            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
