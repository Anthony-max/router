using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using snoopTableros.Models;

namespace snoopTableros.Controllers
{
    public class TablerosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
  
    }
}
