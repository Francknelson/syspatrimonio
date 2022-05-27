using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SysPatrimonio.Models;

namespace SysPatrimonio.Controllers
{
    public class LocaisController : Controller
    {
        private readonly Context _context;

        public LocaisController(Context context)
        {
            _context = context;
        }

        // GET: Locais
        public async Task<IActionResult> Index()
        {
              return _context.Locais != null ? 
                          View(await _context.Locais.ToListAsync()) :
                          Problem("Entity set 'Context.Locais'  is null.");
        }

        // GET: Locais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Locais == null)
            {
                return NotFound();
            }

            var dbLocal = await _context.Locais
                .FirstOrDefaultAsync(m => m.id == id);
            if (dbLocal == null)
            {
                return NotFound();
            }

            return View(dbLocal);
        }

        // GET: Locais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nomelocal,descricaolocal")] DbLocal dbLocal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dbLocal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dbLocal);
        }

        // GET: Locais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Locais == null)
            {
                return NotFound();
            }

            var dbLocal = await _context.Locais.FindAsync(id);
            if (dbLocal == null)
            {
                return NotFound();
            }
            return View(dbLocal);
        }

        // POST: Locais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nomelocal,descricaolocal")] DbLocal dbLocal)
        {
            if (id != dbLocal.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dbLocal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DbLocalExists(dbLocal.id))
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
            return View(dbLocal);
        }

        // GET: Locais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Locais == null)
            {
                return NotFound();
            }

            var dbLocal = await _context.Locais
                .FirstOrDefaultAsync(m => m.id == id);
            if (dbLocal == null)
            {
                return NotFound();
            }

            return View(dbLocal);
        }

        // POST: Locais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Locais == null)
            {
                return Problem("Entity set 'Context.Locais'  is null.");
            }
            var dbLocal = await _context.Locais.FindAsync(id);
            if (dbLocal != null)
            {
                _context.Locais.Remove(dbLocal);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DbLocalExists(int id)
        {
          return (_context.Locais?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
