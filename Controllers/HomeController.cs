using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using uit_project_framework.Models;
using Microsoft.EntityFrameworkCore;


namespace uit_project_framework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopContext _context;

        public HomeController(ShopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // get 4 sp ban chay
            // get 3 bai moi nhat
            ViewBag.TopSellerProducts=_context.Products.Take(4).ToList();
            ViewBag.NewPosts = _context.Posts.Take(3).ToList();
            return View();
        }

        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
    }
}