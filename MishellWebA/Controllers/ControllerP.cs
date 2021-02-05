using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MishellWebA.Controllers
{
    public class ControllerP : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ObtenerDato(string nombre, string apellido, string cedula, string nacionalidad, string profesion, string grupo)
        {
            var dato = 0;
            ViewBag.Dato = dato;
            return View();
        }
    }
}
