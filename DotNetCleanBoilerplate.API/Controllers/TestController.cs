using Microsoft.AspNetCore.Mvc;

namespace DotNetCleanBoilerplate.API.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
