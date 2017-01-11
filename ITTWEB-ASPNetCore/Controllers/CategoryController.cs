using ITTWEB_ASPNetCore.Core;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.ViewModels.CategoryViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ITTWEB_ASPNetCore.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [AllowAnonymous]
        public IActionResult Categories()
        {
            //var categories = CategoryMock.GetCategories();
            var categories = _unitOfWork.Categories.GetAll();

            var viewModel = new CategoryViewModel
            {
                Categories =  categories
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SaveCategory(Category category)
        {
            if (category.CategoryId == 0)
            {
                //If creating
                _unitOfWork.Categories.Add(category);
            }
            else
            {
                //If editing
                var categoryInDb = _unitOfWork.Categories.Get(category.CategoryId);
                //var categoryInDb = _unitOfWork.Categories.Single(c => c.CategoryId == category.CategoryId);
                categoryInDb.Name = category.Name;

            }
            _unitOfWork.Complete();

            return RedirectToAction("Categories", "Category");
        }

        public IActionResult EditCategory(int id)
        {
            var category = _unitOfWork.Categories.Get(id);
            //var category = CategoryMock.GetCategories().SingleOrDefault(c => c.CategoryId == id);

            return View(category);
        }

        //TODO works with HttpPost
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            var categoryInDb = _unitOfWork.Categories.Get(category.CategoryId);

            _unitOfWork.Categories.Remove(categoryInDb);

            _unitOfWork.Complete();

            return RedirectToAction("Categories", "Category");
        }

    }
}