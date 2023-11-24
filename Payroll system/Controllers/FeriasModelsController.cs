using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Payroll_system.Data;
using Payroll_system.Models;

namespace Payroll_system.Controllers
{
    public class FeriasModelsController : Controller
    {
        private readonly BancoContext _context;

        public FeriasModelsController(BancoContext context)
        {
            _context = context;
        }

        // GET: FeriasModels
        public async Task<IActionResult> Index()
        {
              return _context.ferias != null ? 
                          View(await _context.ferias.ToListAsync()) :
                          Problem("Entity set 'BancoContext.ferias'  is null.");
        }

        // GET: FeriasModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ferias == null)
            {
                return NotFound();
            }

            var feriasModel = await _context.ferias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feriasModel == null)
            {
                return NotFound();
            }

            return View(feriasModel);
        }

        // GET: FeriasModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FeriasModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cargo,DataFerias")] FeriasModel feriasModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feriasModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feriasModel);
        }

        // GET: FeriasModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ferias == null)
            {
                return NotFound();
            }

            var feriasModel = await _context.ferias.FindAsync(id);
            if (feriasModel == null)
            {
                return NotFound();
            }
            return View(feriasModel);
        }

        // POST: FeriasModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cargo,DataFerias")] FeriasModel feriasModel)
        {
            if (id != feriasModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feriasModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeriasModelExists(feriasModel.Id))
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
            return View(feriasModel);
        }

        // GET: FeriasModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ferias == null)
            {
                return NotFound();
            }

            var feriasModel = await _context.ferias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (feriasModel == null)
            {
                return NotFound();
            }

            return View(feriasModel);
        }

        // POST: FeriasModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ferias == null)
            {
                return Problem("Entity set 'BancoContext.ferias'  is null.");
            }
            var feriasModel = await _context.ferias.FindAsync(id);
            if (feriasModel != null)
            {
                _context.ferias.Remove(feriasModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeriasModelExists(int id)
        {
          return (_context.ferias?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
