using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPTesting.Models;

namespace ASPTesting.Controllers;

public class MainController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
}