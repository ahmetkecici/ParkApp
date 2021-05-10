using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using ParkApp.User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkApp.User.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _localizer;

        public UserController(IStringLocalizer<UserController> localizer )
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var name_surname = _localizer["Name_Value"];
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(UserCreaterequestModel model)
        {
            return View(model);
         }
    }
}
