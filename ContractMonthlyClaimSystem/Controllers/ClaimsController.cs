using Microsoft.AspNetCore.Mvc;

namespace ContractMonthlyClaimSystem.Controllers
{
    public class ClaimsController : Controller
    {
        
            public IActionResult Submit() {
            return View(); 
        }
        public IActionResult History() { 
            return View();
        }
    }
    }

