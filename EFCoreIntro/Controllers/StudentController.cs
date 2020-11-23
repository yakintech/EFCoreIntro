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
            List<Student> students = _context.Students.ToList();

            return View(students);
        }
        

        public IActionResult Add()
        {
            ViewBag.ad = "Bilge adam";
            ViewBag.Islemdurum = false;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            ViewBag.Islemdurum = true;

            return View();
        }


        public IActionResult Add2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add2(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return RedirectToAction("Index","Student");
        }
    }
}
