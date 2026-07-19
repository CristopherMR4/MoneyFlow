using Microsoft.AspNetCore.Mvc;
using MoneyFlow.Managers;

namespace MoneyFlow.Context
{
    public class TransactionController(ServiceManager _serviceManager, TransactionManager _transactionManager) : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
