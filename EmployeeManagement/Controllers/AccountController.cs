using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> logger;

        public AccountController ( ILogger<AccountController> logger)
        {
   
            this.logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            return RedirectToAction("index", "home");
        }

        [HttpGet, AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

      
        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }
    }
}