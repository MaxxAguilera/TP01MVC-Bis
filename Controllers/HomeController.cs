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
        Grupo grupo = new Grupo();
        ViewBag.Grupo = grupo.DevolverCabañas();
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

    public IActionResult MostrarCabañas(){
        Complejo Complejo = new Complejo();
        List<string> cabañas = new List();
        foreach (string c in cabañas.GetNombre())
        {
            cabañas.Add(c)
        }
        Cabaña cabaña = grupo.GetCabaña(id);
        ViewBag.cabaña = cabaña;
        return View("InfoIntegrante");
    }
}