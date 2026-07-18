using Azure;
using Azure.Core;
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
            //Requerimiento de campos
            if(!ModelState.IsValid) return View(modelVM);
            
            //WARNING: Cambiar el User IDS
            modelVM.Userid = 1;
            var response = _serviceManager.New(modelVM);
            if(response == 1)return RedirectToAction("Index"); 
            ViewBag.message = "Error";

            return View();

        }

        [HttpGet]
        public IActionResult EditService(int ID)
        {
            var model = _serviceManager.GetById(ID);
            return View(model);
        }

        [HttpPost]
        public IActionResult EditService(ServiceVM modelVM)
        {
            if (!ModelState.IsValid) return View(modelVM);
            var response = _serviceManager.Edit(modelVM);
            if (response == 1) return RedirectToAction("index");

            ViewBag.message ="Error al Editar";

            return View(modelVM);

        }

        public IActionResult DeleteService(int id)
        {
            var response = _serviceManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
