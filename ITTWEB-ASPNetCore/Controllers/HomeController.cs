using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ITTWEB_ASPNetCore.Data;
using ITTWEB_ASPNetCore.Models.AccountViewModels;
using ITTWEB_ASPNetCore.ViewModels.CategoryViewModels;
using ITTWEB_ASPNetCore.ViewModels.ComponentTypeViewModels;
using ITTWEB_ASPNetCore.ViewModels.ComponentViewModel;
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
            //var categories = _context.Catagories.ToList();
            var categories = CategoryMock.GetCategories();

            var viewModel = new CategoryViewModel
            {
                Categories = categories
            };


            return View(viewModel);
        }

        public IActionResult ComponentType(int id, string title)
        {
           
            var componentTypes = ComponentTypeMock.GetComponentTypes();
            var viewModel = new ComponentTypeViewModel
            {
                Title = title,
                ComponentTypes = componentTypes
            };

            return View(viewModel);
        }
        public IActionResult Component(int id)
        {
            var viewModel = new ComponentViewModel
            {
                ComponentType = ComponentTypeMock.GetComponentTypes().SingleOrDefault(t => t.ComponentTypeId == id) 
            };

            return View(viewModel);
        }

        public IActionResult SaveCategory(string name)
        {
            var category = new Category
            {
                Name = name
            };

            //TODO save in db
            return RedirectToAction("Category", "Home");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}