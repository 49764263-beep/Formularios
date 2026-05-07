using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Formularios.Models;

namespace Formularios.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    
    [HttpPost]
    public ActionResult GuardarDatos(string nombre, int edad, int dni, bool trabajando, int tipo, int ingreso, bool ConDeudas, int tipoDeuda, int monto, int plazo, bool Terminos)
    {
        Console.WriteLine(trabajando);
        Console.WriteLine(ingreso);
        Console.WriteLine(monto);
        Console.WriteLine(ConDeudas);
        Console.WriteLine(Terminos);

        if(edad >= 18 && trabajando && ingreso >= 250000 && (monto * 5) <= ingreso && ConDeudas == false && Terminos )
        {
            return View("Apto");
        }
        else{
            return View("NoApto");
        }
    }

    public IActionResult Index()
    {

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
}
