using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Perfume.Data;
using Perfume.Models;

namespace Perfume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PerfumeDbContext _context;

        public HomeController(ILogger<HomeController> logger,PerfumeDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var perfumes = _context.Perfumes.ToList();
            return View(perfumes);
        }

        [HttpGet("{id}")]
        public IActionResult Index(int id)
        {
            var perfume = _context.Users.Find(id);
            return View(perfume);
        }

        [HttpPost]
        public IActionResult Index(PerfumeModel perfume)
        {
            _context.Perfumes.AddAsync(perfume);
            _context.SaveChangesAsync();
            return View();
        }

    }
}
