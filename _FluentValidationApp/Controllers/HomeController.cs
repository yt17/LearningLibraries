using _FluentValidationApp.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace _FluentValidationApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IValidator<UserInfo> UserInfovalidator;


        public HomeController(ILogger<HomeController> logger, IValidator<UserInfo> UserInfovalidator)
        {
            _logger = logger;
            this.UserInfovalidator = UserInfovalidator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test() { return View(); }

        [HttpPost]
        public IActionResult Test(UserInfo model) {

            var result = UserInfovalidator.Validate(model);
            if (result.IsValid)
            {
                //successfull code
            }
            else
            {
                return BadRequest(result.Errors.Select(x => new { property = x.PropertyName, error = x.ErrorMessage }));
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}