using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITTWEB_ASPNetCore.Core;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.ViewModels.ComponentTypeViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ITTWEB_ASPNetCore.Controllers
{
    public class ComponentTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ComponentTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ComponentTypes(int id)
        {

            //var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == id);

            //var componentTypes = category.CategoryComponentTypes.Select(categoryComponentType => categoryComponentType.ComponentType).ToList();

            //var category = _unitOfWork.Catagories.Include(c => c.CategoryComponentTypes).ThenInclude(comp => comp.ComponentType).Single(c => c.CategoryId == id);
            var category = _unitOfWork.Categories.GetCategoryWithComponentTypes(id);
            //TODO correct way or make async and get from db ??
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

            //            if (viewModel.ComponentType.ComponentTypeId == 0)
            //            {
            //                //If creating
            //                viewModel.ComponentType.Status = ComponentTypeStatus.ReservedAdmin;
            //
            //                var categoryComponentType = new CategoryComponentType();
            //
            //                categoryComponentType.CategoryId = viewModel.Category.CategoryId;
            //
            //                categoryComponentType.ComponentType = viewModel.ComponentType;
            //
            //                _unitOfWork.CategoryComponentTypes.Add(categoryComponentType);
            //            }
            //            else
            //            {
            //                //If editing
            //                var componentTypeInDb =
            //                    _context.ComponentTypes.Single(c => c.ComponentTypeId == viewModel.ComponentType.ComponentTypeId);
            //
            //                componentTypeInDb.ComponentName = viewModel.ComponentType.ComponentName;
            //                componentTypeInDb.ComponentInfo = viewModel.ComponentType.ComponentInfo;
            //                componentTypeInDb.Location = viewModel.ComponentType.Location;
            //                componentTypeInDb.Status = viewModel.ComponentType.Status;
            //                componentTypeInDb.Datasheet = viewModel.ComponentType.Datasheet;
            //                componentTypeInDb.ImageUrl = viewModel.ComponentType.ImageUrl;
            //                componentTypeInDb.Manufacturer = viewModel.ComponentType.Manufacturer;
            //                componentTypeInDb.WikiLink = viewModel.ComponentType.WikiLink;
            //                componentTypeInDb.AdminComment = viewModel.ComponentType.AdminComment;
            //                componentTypeInDb.Image = viewModel.ComponentType.Image;
            //            }
            //
            //
            //
            //            _context.SaveChanges();





            return RedirectToAction("ComponentTypes", "ComponentType", new { id = viewModel.Category.CategoryId });
        }

        //Edit
        public IActionResult EditComponentType(int componentTypeId, int categoryId)
        {
            //TODO Make Async!!
            //var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == categoryId);
            // var componentType = ComponentTypeMock.GetComponentTypes().SingleOrDefault(c => c.ComponentTypeId == componentTypeId);

            var componentType = _unitOfWork.ComponentTypes.SingleOrDefault(c => c.ComponentTypeId == componentTypeId);
            var category = _unitOfWork.Categories.SingleOrDefault(c => c.CategoryId == categoryId);

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
            //var categoryComponentTypeInDb =
            //    _context.CategoryComponentTypes.Single(c => c.ComponentTypeId == viewModel.ComponentType.ComponentTypeId);
            //_context.CategoryComponentTypes.Remove(categoryComponentTypeInDb);
            //var componentTypeInDb =
            //    _context.ComponentTypes.Single(c => c.ComponentTypeId == viewModel.ComponentType.ComponentTypeId);
            //_context.SaveChanges();


            return RedirectToAction("ComponentTypes", "ComponentType", new { id = viewModel.Category.CategoryId });
        }

        //Search
        public IActionResult SearchComponentType(ComponentTypeViewModel viewModel)
        {


            //var category =
            //    _context.Catagories.Include(cType => cType.CategoryComponentTypes).ThenInclude(d => d.ComponentType)
            //        .Single(c => c.CategoryId == viewModel.Category.CategoryId);

            //IEnumerable<CategoryComponentType> searchResult;

            //if (!string.IsNullOrWhiteSpace(viewModel.SearchText))
            //{
            //   searchResult =
            //   from cType in category.CategoryComponentTypes
            //   where cType.ComponentType.ComponentName.ToLower().Contains(viewModel.SearchText.ToLower())
            //        || cType.ComponentType.WikiLink.ToLower().Contains(viewModel.SearchText.ToLower())
            //        || cType.ComponentType.Status.ToString().ToLower().Contains(viewModel.SearchText.ToLower())

            //   select cType;
            //}
            //else
            //{
            //    searchResult =
            //        from cType in category.CategoryComponentTypes
            //        select cType;
            //}



            //var componentTypes =
            //    searchResult.Select(categoryComponenType => categoryComponenType.ComponentType).ToList();

            //var returnViewModel = new ComponentTypeViewModel
            //{
            //    Category = category,
            //    ComponentTypes = componentTypes
            //};

            var returnViewModel = new ComponentTypeViewModel
            {
                Category = new Category(),
                ComponentTypes = new List<ComponentType>()
            };

            return View(returnViewModel);
        }

    }
}