using Microsoft.AspNetCore.Mvc;
using MoneyFlow.Context;

namespace MoneyFlow.Context
{
    public class ServiceController(AppDbContext _dbContext) : Controller
    {
        public IActionResult Index()
        {

            var list = _dbContext.Services.ToList();
            return View(list);
        }
    }
}
