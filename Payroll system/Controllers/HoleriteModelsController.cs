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
    public class HoleriteModelsController : Controller
    {
        private readonly BancoContext _context;

        public HoleriteModelsController(BancoContext context)
        {
            _context = context;
        }

        // GET: HoleriteModels
        public async Task<IActionResult> Index()
        {
              return _context.Salario != null ? 
                          View(await _context.Salario.ToListAsync()) :
                          Problem("Entity set 'BancoContext.Salario'  is null.");
        }

        // GET: HoleriteModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Salario == null)
            {
                return NotFound();
            }

            var holeriteModel = await _context.Salario
                .FirstOrDefaultAsync(m => m.HorasTrabalhadas == id);
            if (holeriteModel == null)
            {
                return NotFound();
            }

            return View(holeriteModel);
        }

        // GET: HoleriteModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HoleriteModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HorasTrabalhadas,AtrasosEFaltas,SalarioBruto,SalarioLiquido,TaxasDePagamento,ImpostoDeRenda,Inss,HorasExtras,AdicionalNoturno,AdicionalPericulosidade,AdicionalInsalubridade,Fgts")] HoleriteModel holeriteModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(holeriteModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(holeriteModel);
        }

        // GET: HoleriteModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Salario == null)
            {
                return NotFound();
            }

            var holeriteModel = await _context.Salario.FindAsync(id);
            if (holeriteModel == null)
            {
                return NotFound();
            }
            return View(holeriteModel);
        }

        // POST: HoleriteModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("HorasTrabalhadas,AtrasosEFaltas,SalarioBruto,SalarioLiquido,TaxasDePagamento,ImpostoDeRenda,Inss,HorasExtras,AdicionalNoturno,AdicionalPericulosidade,AdicionalInsalubridade,Fgts")] HoleriteModel holeriteModel)
        {
            if (id != holeriteModel.HorasTrabalhadas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(holeriteModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoleriteModelExists(holeriteModel.HorasTrabalhadas))
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
            return View(holeriteModel);
        }

        // GET: HoleriteModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Salario == null)
            {
                return NotFound();
            }

            var holeriteModel = await _context.Salario
                .FirstOrDefaultAsync(m => m.HorasTrabalhadas == id);
            if (holeriteModel == null)
            {
                return NotFound();
            }

            return View(holeriteModel);
        }

        // POST: HoleriteModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Salario == null)
            {
                return Problem("Entity set 'BancoContext.Salario'  is null.");
            }
            var holeriteModel = await _context.Salario.FindAsync(id);
            if (holeriteModel != null)
            {
                _context.Salario.Remove(holeriteModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoleriteModelExists(string id)
        {
          return (_context.Salario?.Any(e => e.HorasTrabalhadas == id)).GetValueOrDefault();
        }
    }
}
