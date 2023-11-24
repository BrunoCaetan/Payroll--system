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
    public class LicencasModelsController : Controller
    {
        private readonly BancoContext _context;

        public LicencasModelsController(BancoContext context)
        {
            _context = context;
        }

        // GET: LicencasModels
        public async Task<IActionResult> Index()
        {
              return _context.Licencas != null ? 
                          View(await _context.Licencas.ToListAsync()) :
                          Problem("Entity set 'BancoContext.Licencas'  is null.");
        }

        // GET: LicencasModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Licencas == null)
            {
                return NotFound();
            }

            var licencasModel = await _context.Licencas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licencasModel == null)
            {
                return NotFound();
            }

            return View(licencasModel);
        }

        // GET: LicencasModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LicencasModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Cargo,licenca,DataLicenca")] LicencasModel licencasModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(licencasModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(licencasModel);
        }

        // GET: LicencasModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Licencas == null)
            {
                return NotFound();
            }

            var licencasModel = await _context.Licencas.FindAsync(id);
            if (licencasModel == null)
            {
                return NotFound();
            }
            return View(licencasModel);
        }

        // POST: LicencasModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Cargo,licenca,DataLicenca")] LicencasModel licencasModel)
        {
            if (id != licencasModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(licencasModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LicencasModelExists(licencasModel.Id))
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
            return View(licencasModel);
        }

        // GET: LicencasModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Licencas == null)
            {
                return NotFound();
            }

            var licencasModel = await _context.Licencas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (licencasModel == null)
            {
                return NotFound();
            }

            return View(licencasModel);
        }

        // POST: LicencasModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Licencas == null)
            {
                return Problem("Entity set 'BancoContext.Licencas'  is null.");
            }
            var licencasModel = await _context.Licencas.FindAsync(id);
            if (licencasModel != null)
            {
                _context.Licencas.Remove(licencasModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LicencasModelExists(int id)
        {
          return (_context.Licencas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
