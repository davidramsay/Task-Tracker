using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Controllers
{
    public class MenuController : Controller
    {
        // GET: /Menu/
        public IActionResult Index()
        {
            return View();
        }
    }
}
