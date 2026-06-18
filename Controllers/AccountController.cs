using Microsoft.AspNetCore.Mvc;

namespace MRBS_BSES.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string employeeId, string password)
        {
            // Authentication logic later

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}