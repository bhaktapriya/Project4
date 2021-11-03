using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project.Models;

namespace Project.Controllers
{
    public class PizzasController : Controller
    {
        private readonly PizzaDBContext _context;

        public PizzasController(PizzaDBContext context)
        {
            _context = context;
        }

        // GET: Pizzas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tblpizzalists.ToListAsync());
        }

        // GET: Pizzas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblpizzalist = await _context.Tblpizzalists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblpizzalist == null)
            {
                return NotFound();
            }

            return View(tblpizzalist);
        }
        
        public IActionResult Order()
        {
            return View();
        }
        private bool TblpizzalistExists(int id)
        {
            return _context.Tblpizzalists.Any(e => e.Id == id);
        }
    }
}
