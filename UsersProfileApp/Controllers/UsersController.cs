using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserProfileApp.Core.Services.Interfaces;
using UsersProfileApp.DataStore.Models;
using UsersProfileApp.ViewModels;

namespace UsersProfileApp.Controllers
{
    public class UsersController : Controller
    {
        private IUserService _userDetails;

        public UsersController(IUserService userDetails)
        {
            _userDetails = userDetails;
        }

        public IActionResult Details()
        {
            var users = Download();
            List<UsersViewModel> usersViewModels = new List<UsersViewModel>();
            foreach (var user in users)
            {
                var userVm = new UsersViewModel
                {
                    FirstName = user.FirstName,
                    UserId = user.Id,
                    LastName = user.LastName
                };
                usersViewModels.Add(userVm);
            }
            ViewBag.Users = usersViewModels; 
            return View();
        }

        public IActionResult Create(UsersViewModel newuser)
        {
            if (ModelState.IsValid)
            {
                Users user = new Users
                {
                    FirstName = newuser.FirstName,
                    LastName = newuser.LastName
                };
                _userDetails.SaveUser(user);
                ViewData["Message"] = "Success";
            }
            return RedirectToAction("Details");
        }

        private IEnumerable<Users> Download()
        {
            return _userDetails.GetUsers(); 
        }
    }
}
