using ITTWEB_ASPNetCore.Core;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.ViewModels.ComponentViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ITTWEB_ASPNetCore.Controllers
{
    [Authorize]
    public class ComponentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ComponentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [AllowAnonymous]
        public IActionResult Components(int id)
        {
//            var viewModel = new ComponentViewModel
//            {
//                ComponentType = ComponentTypeMock.GetComponentTypes().SingleOrDefault(t => t.ComponentTypeId == id)
//            };

            var componentTypeInDb = _unitOfWork.ComponentTypes.Get(id);

            var viewModel = new ComponentViewModel()
            {
                ComponentType = componentTypeInDb,
                ComponentCount = componentTypeInDb.Components.Count
            };

            return View(viewModel);
        }

        public IActionResult EditComponent(int componentId)
        {
            var componentInDb = _unitOfWork.Components.Get(componentId);

            var viewModel = new ComponentViewModel()
            {
                Component = componentInDb
            };

            return View(viewModel);
        }


        public IActionResult SaveComponent(ComponentViewModel viewModel)
        {
            //TODO make this for repository

            if (viewModel.Component.ComponentId == 0)
            {
                viewModel.Component.ComponentTypeId = viewModel.ComponentType.ComponentTypeId;

                viewModel.Component.ComponentNumber = viewModel.ComponentCount + 1;

                _unitOfWork.Components.Add(viewModel.Component);
            }
            else
            {
                var componentIndb = _unitOfWork.Components.Get(viewModel.Component.ComponentId);

                componentIndb.ComponentNumber = viewModel.Component.ComponentNumber;
                componentIndb.SerialNo = viewModel.Component.SerialNo;
                componentIndb.Status = viewModel.Component.Status;
                componentIndb.AdminComment = viewModel.Component.AdminComment;
                componentIndb.UserComment = viewModel.Component.UserComment;
                componentIndb.CurrentLoanInformationId = viewModel.Component.CurrentLoanInformationId;
            }

            _unitOfWork.Complete();

            return RedirectToAction("Component", "Component", new {id = viewModel.Component.ComponentTypeId});
        }

        //Delete
        [HttpPost]
        public IActionResult DeleteComponent(Component component)
        {
            //TODO make this for repository

            var componentInDb = _unitOfWork.Components.Get(component.ComponentId);

            _unitOfWork.Components.Remove(componentInDb);

            _unitOfWork.Complete();

            return RedirectToAction("Component", "Component", new {id = component.ComponentTypeId});
        }
    }
}