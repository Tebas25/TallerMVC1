using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TallerMVC1.Models;

namespace TallerMVC1.Controllers
{
    public class EstadiosController : Controller
    {
        private readonly EquiposLigaProEcuadorContext _context;

        public EstadiosController(EquiposLigaProEcuadorContext context)
        {
            _context = context;
        }

        // GET: Estadios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estadios.ToListAsync());
        }

        // GET: Estadios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadios = await _context.Estadios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadios == null)
            {
                return NotFound();
            }

            return View(estadios);
        }

        // GET: Estadios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estadios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Direccion,capacidad")] Estadios estadios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadios);
        }

        // GET: Estadios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadios = await _context.Estadios.FindAsync(id);
            if (estadios == null)
            {
                return NotFound();
            }
            return View(estadios);
        }

        // POST: Estadios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Direccion,capacidad")] Estadios estadios)
        {
            if (id != estadios.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadiosExists(estadios.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(estadios);
        }

        // GET: Estadios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadios = await _context.Estadios
                .FirstOrDefaultAsync(m => m.Id == id);
            if (estadios == null)
            {
                return NotFound();
            }

            return View(estadios);
        }

        // POST: Estadios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estadios = await _context.Estadios.FindAsync(id);
            if (estadios != null)
            {
                _context.Estadios.Remove(estadios);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadiosExists(int id)
        {
            return _context.Estadios.Any(e => e.Id == id);
        }
    }
}
