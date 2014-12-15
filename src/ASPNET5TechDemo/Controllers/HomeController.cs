using Microsoft.AspNet.Mvc;
using ASPNET5TechDemo.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET5TechDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var u = new User() { FirstName = "Piet", LastName = "Snot" };
            return View(u);
        }
    }
}
