using Microsoft.AspNetCore.Mvc;

namespace eTicketsProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
