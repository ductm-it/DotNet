using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace uit_project_framework.Controllers
{
    public class ThankyouController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}