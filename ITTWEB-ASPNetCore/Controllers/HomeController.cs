using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ITTWEB_ASPNetCore.Data;
using ITTWEB_ASPNetCore.Models;
using ITTWEB_ASPNetCore.Models.AccountViewModels;
using ITTWEB_ASPNetCore.ViewModels.CategoryViewModels;
using ITTWEB_ASPNetCore.ViewModels.ComponentTypeViewModels;
using ITTWEB_ASPNetCore.ViewModels.ComponentViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        //--------------------Category----------------------------
        public IActionResult Category()
        {
            var categories = CategoryMock.GetCategories();
            //var categories = _context.Catagories.ToList();

            var viewModel = new CategoryViewModel
            {
                Categories = categories
            };


            return View(viewModel);
        }

        //Create
        [HttpPost]
        public IActionResult SaveCategory(Category category)
        {
            //if (category.CategoryId == 0)
            //{
            //    _context.Catagories.Add(category);
            //}
            //else
            //{
            //    var categoryInDb = _context.Catagories.Single(c => c.CategoryId == category.CategoryId);
            //    categoryInDb.Name = category.Name;

            //}
            //_context.SaveChanges();

            return RedirectToAction("Category", "Home");
        }

        //Edit
        public IActionResult EditCategory(int id, string title)
        {

            //var category = _context.Catagories.Single(c => c.CategoryId == id);
            var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == id);

            return View(category);
        }


        //Delete
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            //TODO: Delete Category in database
            //var categoryInDb = _context.Catagories.Single(c => c.CategoryId == category.CategoryId);

            //_context.Catagories.Remove(categoryInDb);

            //_context.SaveChanges();

            return RedirectToAction("Category", "Home");
        }


        //---------------ComponentType-------------------------------

        public IActionResult ComponentType(int id)
        {

            var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == id);

            var componentTypes = category.CategoryComponentTypes.Select(categoryComponentType => categoryComponentType.ComponentType).ToList();

            //var category = _context.Catagories.Include(c => c.CategoryComponentTypes).ThenInclude(comp => comp.ComponentType).Single(c => c.CategoryId == id);

            //var componentTypes = category.CategoryComponentTypes.Select(categoryComponenType => categoryComponenType.ComponentType).ToList();

            var viewModel = new ComponentTypeViewModel
            {
                Title = category.Name,
                ComponentTypes = componentTypes
            };

            return View(viewModel);
        }

        //Create
        public IActionResult CreateComponentType(string title)
        {
            //TODO: Create new ComponentType in Database
            var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == 1);

            return View(category);
        }

        //Edit
        public IActionResult EditComponentType(int id)
        {
           

            var componentType = ComponentTypeMock.GetComponentTypes().SingleOrDefault(c => c.ComponentTypeId == id);

            return View(componentType);
        }

        //Save
        public IActionResult SaveComponentType()
        {
            //TODO: Update ComponentType in Database
            var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == 1);

            return RedirectToAction("ComponentType", "Home");
        }

        //Delete
        public IActionResult DeleteComponentType(int id)
        {
            //TODO: Deletet ComponentType ind database
            return RedirectToAction("ComponentType", "Home");
        }


        //-----------------------Component----------------------------------
        public IActionResult Component(int id)
        {
            var viewModel = new ComponentViewModel
            {
                ComponentType = ComponentTypeMock.GetComponentTypes().SingleOrDefault(t => t.ComponentTypeId == id) 
            };

            return View(viewModel);
        }

 

        public IActionResult Error()
        {
            return View();
        }
    }
}