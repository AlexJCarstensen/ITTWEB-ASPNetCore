using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITTWEB_ASPNetCore.Data;
using ITTWEB_ASPNetCore.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITTWEB_ASPNetCore.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category()
        {
            var categories = _context.Catagories.ToList();

            var viewmodel = new CategoryViewModel
            {
                Categories = categories
            };


            return View(viewmodel);
        }

        public IActionResult ComponentType()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Component()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}