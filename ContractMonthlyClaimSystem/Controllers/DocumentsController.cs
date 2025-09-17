using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class DocumentsController : Controller
    {
        public IActionResult Upload()
        {
            return View();
        }
    }
}
