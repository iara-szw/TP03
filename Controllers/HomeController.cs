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
         ViewBag.catalogo = Catalogo.devolverCatalogo();
        if(ViewBag.catalogo.Count == 0){
             Catalogo.InicializarCatalogo(); 
             ViewBag.catalogo = Catalogo.devolverCatalogo();
        }
        return View();
    }

        public IActionResult VerAlbum(int id)
    {
        ViewBag.album = Catalogo.albumes[id];
        ViewBag.listaTemas = Catalogo.albumes[id].temas;
        return View();
    }

}
