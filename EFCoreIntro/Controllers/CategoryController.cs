using EFCoreIntro.Models.ORM.Context;
using EFCoreIntro.Models.ORM.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Controllers
{
    public class CategoryController : Controller
    {

        private readonly SchoolContext _context;

        public CategoryController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return View();
        }
    }
}
