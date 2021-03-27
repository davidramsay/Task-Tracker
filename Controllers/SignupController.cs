using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskTrackerPrototype.Controllers
{
    public class SignupController : Controller
    {
        // GET: /Signup/
        public IActionResult Index()
        {
            return View();
        }
        //hash password and store to database
    }
}
