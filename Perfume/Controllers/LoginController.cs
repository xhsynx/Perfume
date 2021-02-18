using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Perfume.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Perfume.Controllers
{

    public class LoginController : Controller
    {
        private readonly PerfumeDbContext _context;

        public LoginController(PerfumeDbContext context)
        {
            _context = context;
        }

        // GET: /<controller>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _context.Users.Find(id);
            return View(user);
        }

    }
}
