using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RednitDev.Models;

namespace RednitDev.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult SignUp()
    {
        return View();
    }

}
