using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aula05Routes.Controllers
{
    public class Inicio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}