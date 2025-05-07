using Microsoft.AspNetCore.Mvc;

namespace Lesson02.Controllers
{
    public class NthProductController : Controller
    {
        public IActionResult NthIndex()
        {
            ViewData["messageData"] = "Du lieu tu viewData";
            ViewBag.messageData = "Du lieu tu ViewBag";
            TempData["messageData"] = "Du lieu TempData";
            return View();
        }
    }
}
