using Microsoft.AspNetCore.Mvc;
using MyShop.Models;

namespace MyShop.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
