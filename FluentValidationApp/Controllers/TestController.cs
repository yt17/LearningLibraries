using FluentValidationApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index([FromBody] UserInfo Model)
        {
            return View();
        }
      
    }
}
