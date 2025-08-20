using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers;

public class CalculatorController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}