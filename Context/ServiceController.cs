using Microsoft.AspNetCore.Mvc;

namespace MoneyFlow.Context
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
