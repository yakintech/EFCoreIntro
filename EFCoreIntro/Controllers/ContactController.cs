using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreIntro.Models.VM;

namespace EFCoreIntro.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactVM model)
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(string ad, string soyad, string email)
        //{
        //    return View();
        //}
    }
}
