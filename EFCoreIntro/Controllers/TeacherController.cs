using EFCoreIntro.Models.ORM.Context;
using EFCoreIntro.Models.ORM.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreIntro.Controllers
{
    public class TeacherController : Controller
    {
        private readonly SchoolContext _context;

        public TeacherController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Teacher> teachers = _context.Teachers.ToList();
            return View(teachers);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Teacher entity)
        {
            _context.Teachers.Add(entity);
            _context.SaveChanges();
            return View();
        }


        public IActionResult Edit(int id)
        {
            Teacher teacher = _context.Teachers.FirstOrDefault(x => x.ID == id);

            return View(teacher);
        }


        [HttpPost]
        public IActionResult Edit(Teacher model)
        {
            Teacher guncellenecek = _context.Teachers.FirstOrDefault(x => x.ID == model.ID);

            guncellenecek.Name = model.Name;
            guncellenecek.Surname = model.Surname;
            guncellenecek.Phone = model.Phone;
            guncellenecek.Address = model.Address;
            guncellenecek.EMail = model.EMail;

            _context.SaveChanges();


            return View(guncellenecek);
        }


    }
}
