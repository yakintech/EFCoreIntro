using EFCoreIntro.Models.ORM.Context;
using EFCoreIntro.Models.ORM.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        private readonly SchoolContext _context;


        public ProductController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }


        public IActionResult Add()
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.CategoryList = categories;

            return View();
        }


        [HttpPost]
        public IActionResult Add(Product model)
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.CategoryList = categories;

            _context.Products.Add(model);
            _context.SaveChanges();
            return View();
        }
    }

}
