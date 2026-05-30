using Azure;
using Microsoft.AspNetCore.Mvc;
using MoneyFlow.Context;
using MoneyFlow.Managers;

namespace MoneyFlow.Context
{
    public class ServiceController(ServiceManager _serviceManager) : Controller
    {
        public IActionResult Index()
        {
            //WARNING: Cambiar el User IDS
            var list = _serviceManager.GetAll(1);
            return View(list);
        }
    }
}
