using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP01MVC_FINAL.Models;

namespace TP01MVC_FINAL.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Complejo complejo = new Complejo();
        ViewBag.Complejo = complejo;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult MostrarCabaña(int id)
    {
       Complejo complejo = new Complejo(); 
       ViewBag.Cabaña = complejo.GetCabaña(id);
       return View();
    }
}