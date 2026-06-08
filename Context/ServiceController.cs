using Azure;
using Microsoft.AspNetCore.Mvc;
using MoneyFlow.Context;
using MoneyFlow.Managers;
using MoneyFlow.Models;

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

        //NewService

        [HttpGet]
        public IActionResult NewService()
        {

            return View();
        }

        [HttpPost]
        public IActionResult NewService(ServiceVM modelVM)
        {

            ViewBag.message = "Error";

            return View();

        } 
    }
}
