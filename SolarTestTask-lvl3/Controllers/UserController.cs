using Microsoft.AspNetCore.Mvc;
using SolarTestTask_lvl3.Models;
using System.Diagnostics;

namespace SolarTestTask_lvl3.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddUser()
        {
            User u = new User() { UserName = "Tom" };
            ViewData["te"] = "HALIO";
            return View(u);
        }
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string login, string password)
        {
            ViewData["log"] = login;
            ViewData["pass"] = password;
            string authData = $"Login: {login}   Password: {password}";
            return View();
        }

    }
}
