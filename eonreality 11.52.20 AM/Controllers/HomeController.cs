using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eonreality.Models;

namespace eonreality.Controllers
{
    public class HomeController : Controller
    {
        private UserContext dbContext;

        public HomeController(UserContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<User> AllUsers = dbContext.User.ToList();
            ViewBag.Users = AllUsers;
            return View();
        }

        [HttpGet("addUser")]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(User userInDb)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(userInDb);
                dbContext.SaveChanges();
                
                return RedirectToAction("Index");
            }
            else
            {
                return View("addUser");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
