using EFCoreIntro.Models.ORM.Context;
using EFCoreIntro.Models.ORM.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Controllers
{
    public class StudentController : Controller
    {
        private readonly SchoolContext _context;


        public StudentController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Student> studens = _context.Students.ToList();

            return View(studens);
        }
        

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();

            return RedirectToAction("Index","Student");
        }
    }
}
