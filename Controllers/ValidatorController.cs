using Microsoft.AspNetCore.Mvc;

namespace sample3.Controllers
{
    public class ValidatorController : Controller
    {
        public IActionResult Validator()
        {
            if (User.Identity!.IsAuthenticated)
            {
                return RedirectToAction("Privacy", "Home");
            }

            return RedirectToAction("Login", "Validator");
        }

        public IActionResult Login() { 

            return View();
        
        }

        public IActionResult Signout() {

            return RedirectToAction("Login", "Validator");
        }
    }
}
