using EFCoreIntro.Models.ORM.Context;
using EFCoreIntro.Models.ORM.Entities;
using EFCoreIntro.Models.VM;
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
            List<Product> products = _context.Products.Where(q => q.Isdeleted == false).ToList();
            return View(products);
        }


        public IActionResult Add()
        {
            List<Category> categories = _context.Categories.ToList();
            ViewBag.CategoryList = categories;

            return View();
        }


        [HttpPost]
        public IActionResult SearchProduct(ProductSearchVM searchmodel)
        {
            if (ModelState.IsValid)
            {
                List<Product> model = _context.Products.Where(q => q.Name.Contains(searchmodel.name) && q.Price > searchmodel.minprice && q.Price < searchmodel.maxprice).ToList();

                return View("Index", model);
            }
            else
            {
                return RedirectToAction("Index");
            }
        
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


        [HttpPost]
        public IActionResult Delete(int productid)
        {

            //Dışarıdan aldığı productid ye göre product yakalar ve isdelete true yapar.
            Product product = _context.Products.FirstOrDefault(x => x.ID == productid);

            product.Isdeleted = true;

            _context.SaveChanges();


            return RedirectToAction("Index");

        }


        public IActionResult Delete2(int id)
        {
            Product product = _context.Products.FirstOrDefault(x => x.ID == id);
            product.Isdeleted = true;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }   
    }

}
