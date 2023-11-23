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
    public class EmpresaModelsController : Controller
    {
        private readonly BancoContext _context;

        public EmpresaModelsController(BancoContext context)
        {
            _context = context;
        }

        // GET: EmpresaModels
        public async Task<IActionResult> Index()
        {
              return _context.Empresa != null ? 
                          View(await _context.Empresa.ToListAsync()) :
                          Problem("Entity set 'BancoContext.Empresa'  is null.");
        }

        // GET: EmpresaModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Empresa == null)
            {
                return NotFound();
            }

            var empresaModel = await _context.Empresa
                .FirstOrDefaultAsync(m => m.NomeDaEmpresa == id);
            if (empresaModel == null)
            {
                return NotFound();
            }

            return View(empresaModel);
        }

        // GET: EmpresaModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmpresaModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NomeDaEmpresa,Cnpj,RazaoSocial,InscricaoEstadual,Telefone,Endereco,Email")] EmpresaModel empresaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empresaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empresaModel);
        }

        // GET: EmpresaModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Empresa == null)
            {
                return NotFound();
            }

            var empresaModel = await _context.Empresa.FindAsync(id);
            if (empresaModel == null)
            {
                return NotFound();
            }
            return View(empresaModel);
        }

        // POST: EmpresaModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NomeDaEmpresa,Cnpj,RazaoSocial,InscricaoEstadual,Telefone,Endereco,Email")] EmpresaModel empresaModel)
        {
            if (id != empresaModel.NomeDaEmpresa)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empresaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaModelExists(empresaModel.NomeDaEmpresa))
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
            return View(empresaModel);
        }

        // GET: EmpresaModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Empresa == null)
            {
                return NotFound();
            }

            var empresaModel = await _context.Empresa
                .FirstOrDefaultAsync(m => m.NomeDaEmpresa == id);
            if (empresaModel == null)
            {
                return NotFound();
            }

            return View(empresaModel);
        }

        // POST: EmpresaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Empresa == null)
            {
                return Problem("Entity set 'BancoContext.Empresa'  is null.");
            }
            var empresaModel = await _context.Empresa.FindAsync(id);
            if (empresaModel != null)
            {
                _context.Empresa.Remove(empresaModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmpresaModelExists(string id)
        {
          return (_context.Empresa?.Any(e => e.NomeDaEmpresa == id)).GetValueOrDefault();
        }
    }
}
