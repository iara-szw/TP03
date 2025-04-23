using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03.Models;

namespace TP03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SelectAlbum()
    {
         ViewBag.Catalogo = Catalogo.devolverCatalogo();
        if(ViewBag.Catalogo.Count == 0){
             Catalogo.InicializarCatalogo(); 
             ViewBag.Catalogo = Catalogo.devolverCatalogo();
        }
        return View();
    }

        public IActionResult verAlbum(int id)
    {
        return View();
    }

}
