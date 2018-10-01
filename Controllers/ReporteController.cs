using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyecto_personal.Models;

namespace Proyecto_personal.Controllers
{
    public class ReporteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}