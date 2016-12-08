using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ITTWEB_ASPNetCore.Core;
using ITTWEB_ASPNetCore.Core.Domain;
using ITTWEB_ASPNetCore.Models;
using ITTWEB_ASPNetCore.Models.AccountViewModels;
using ITTWEB_ASPNetCore.Persistence;
using ITTWEB_ASPNetCore.ViewModels.CategoryViewModels;
using ITTWEB_ASPNetCore.ViewModels.ComponentTypeViewModels;
using ITTWEB_ASPNetCore.ViewModels.ComponentViewModel;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;

namespace ITTWEB_ASPNetCore.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}