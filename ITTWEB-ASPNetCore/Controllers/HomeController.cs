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
            //var categories = CategoryMock.GetCategories();
            var categories = _context.Catagories.ToList();

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
            if (category.CategoryId == 0)
            {
                //If creating
                _context.Catagories.Add(category);
            }
            else
            {
                //If editing
                var categoryInDb = _context.Catagories.Single(c => c.CategoryId == category.CategoryId);
                categoryInDb.Name = category.Name;

            }
            _context.SaveChanges();

            return RedirectToAction("Category", "Home");
        }

        //Edit
        public IActionResult EditCategory(int id, string title)
        {

            var category = _context.Catagories.Single(c => c.CategoryId == id);
            //var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == id);

            return View(category);
        }


        //Delete
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            //TODO: Delete Category in database
            var categoryInDb = _context.Catagories.Single(c => c.CategoryId == category.CategoryId);

            _context.Catagories.Remove(categoryInDb);

            _context.SaveChanges();

            return RedirectToAction("Category", "Home");
        }


        //---------------ComponentType-------------------------------

        public IActionResult ComponentType(int id)
        {

            //var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == id);

            //var componentTypes = category.CategoryComponentTypes.Select(categoryComponentType => categoryComponentType.ComponentType).ToList();

            var category = _context.Catagories.Include(c => c.CategoryComponentTypes).ThenInclude(comp => comp.ComponentType).Single(c => c.CategoryId == id);

            var componentTypes = category.CategoryComponentTypes.Select(categoryComponenType => categoryComponenType.ComponentType).ToList();

            var viewModel = new ComponentTypeViewModel
            {
                Category = category,
                ComponentTypes = componentTypes
            };

            return View(viewModel);
        }

        //Create
        [HttpPost]
        public IActionResult SaveComponentType(ComponentTypeViewModel viewModel)
        {
            //TODO: Create new ComponentType in Database

            if (viewModel.ComponentType.ComponentTypeId == 0)
            {
                //If creating
                viewModel.ComponentType.Status = ComponentTypeStatus.ReservedAdmin;

                var categoryComponentType = new CategoryComponentType();

                categoryComponentType.CategoryId = viewModel.Category.CategoryId;

                categoryComponentType.ComponentType = viewModel.ComponentType;

                _context.CategoryComponentTypes.Add(categoryComponentType);
            }
            else
            {
                //If editing
                var componentTypeInDb =
                    _context.ComponentTypes.Single(c => c.ComponentTypeId == viewModel.ComponentType.ComponentTypeId);

                componentTypeInDb.ComponentName = viewModel.ComponentType.ComponentName;
                componentTypeInDb.ComponentInfo = viewModel.ComponentType.ComponentInfo;
                componentTypeInDb.Location = viewModel.ComponentType.Location;
                componentTypeInDb.Status = viewModel.ComponentType.Status;
                componentTypeInDb.Datasheet = viewModel.ComponentType.Datasheet;
                componentTypeInDb.ImageUrl = viewModel.ComponentType.ImageUrl;
                componentTypeInDb.Manufacturer = viewModel.ComponentType.Manufacturer;
                componentTypeInDb.WikiLink = viewModel.ComponentType.WikiLink;
                componentTypeInDb.AdminComment = viewModel.ComponentType.AdminComment;
                componentTypeInDb.Image = viewModel.ComponentType.Image;
            }

            

            _context.SaveChanges();

            



            return RedirectToAction("ComponentType", "Home", new {id = viewModel.Category.CategoryId});
        }

        //Edit
        public IActionResult EditComponentType(int componentTypeId, int categoryId)
        {
           

            //var componentType = ComponentTypeMock.GetComponentTypes().SingleOrDefault(c => c.ComponentTypeId == id);

            var componentType = _context.ComponentTypes.SingleOrDefault(c => c.ComponentTypeId == componentTypeId);
            var category = _context.Catagories.Single(c => c.CategoryId == categoryId);

            var viewModel = new EditComponentTypeViewModel()
            {
                Category = category,
                ComponentType = componentType
            };

            return View(viewModel);
        }


        //Delete
        [HttpPost]
        public IActionResult DeleteComponentType(EditComponentTypeViewModel viewModel)
        {
            //TODO: Deletet ComponentType ind database
            var categoryComponentTypeInDb =
                _context.CategoryComponentTypes.Single(c => c.ComponentTypeId == viewModel.ComponentType.ComponentTypeId);
            _context.CategoryComponentTypes.Remove(categoryComponentTypeInDb);
            var componentTypeInDb =
                _context.ComponentTypes.Single(c => c.ComponentTypeId == viewModel.ComponentType.ComponentTypeId);
            _context.SaveChanges();
            

            return RedirectToAction("ComponentType", "Home", new {id = viewModel.Category.CategoryId});
        }


        //-----------------------Component----------------------------------
        public IActionResult Component(int id)
        {
            //var viewModel = new ComponentViewModel
            //{
            //    ComponentType = ComponentTypeMock.GetComponentTypes().SingleOrDefault(t => t.ComponentTypeId == id) 
            //};

            var componentTypeInDb = _context.ComponentTypes.Include(c => c.Components).Single(c => c.ComponentTypeId == id);

            

            var viewModel = new ComponentViewModel()
            {
                ComponentType = componentTypeInDb,
                ComponentCount = componentTypeInDb.Components.Count
            };

            return View(viewModel);
        }

        //Save

        public IActionResult SaveComponent(ComponentViewModel viewModel)
        {
            if (viewModel.Component.ComponentId == 0)
            {
                viewModel.Component.ComponentTypeId = viewModel.ComponentType.ComponentTypeId;

                viewModel.Component.ComponentNumber = viewModel.ComponentCount + 1;

                _context.Components.Add(viewModel.Component);
            }
            else
            {
                
            }

            _context.SaveChanges();

            return RedirectToAction("Component", "Home", new {id = viewModel.ComponentType.ComponentTypeId});
        }

        //Delete
        [HttpPost]
        public IActionResult DeleteComponent(Component component)
        {
            var componentInDb = _context.Components.Single(c => c.ComponentId == component.ComponentId);

            _context.Components.Remove(componentInDb);

            _context.SaveChanges();

            return RedirectToAction("Component", "Home", new {id = component.ComponentTypeId});
        }

 

        public IActionResult Error()
        {
            return View();
        }
    }
}