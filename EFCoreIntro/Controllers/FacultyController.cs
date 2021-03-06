﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreIntro.Models.ORM.Context;
using EFCoreIntro.Models.ORM.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreIntro.Controllers
{
    public class FacultyController : Controller
    {
        private readonly SchoolContext _context;

        public FacultyController(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //select * from Faculties
            List<Faculty> faculties = _context.Faculties.ToList();

            //ID si 3 olan fakülte
            Faculty faculty = _context.Faculties.FirstOrDefault(q => q.ID == 3);


            //adında a harfi geçen fakülteler
            List<Faculty> faculties2 = _context.Faculties.Where(q => q.Name.Contains("a")).ToList();


            return View(faculties);
        }


        [HttpGet]
        public IActionResult FacultyDetail(int id)
        {
            Faculty faculty = _context.Faculties.FirstOrDefault(q => q.ID == id);
            return View(faculty);
        }



        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Faculty faculty)
        {
            //Dışarıdan aldığı fakülte objesini db ye ekler
         
            _context.Faculties.Add(faculty);
            _context.SaveChanges();

            return RedirectToAction("Index", "Faculty");


        }
    }
}