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
    public class FuncionarioModelsController : Controller
    {
        private readonly BancoContext _context;

        public FuncionarioModelsController(BancoContext context)
        {
            _context = context;
        }

        // GET: FuncionarioModels
        public async Task<IActionResult> Index()
        {
              return _context.Funcionario != null ? 
                          View(await _context.Funcionario.ToListAsync()) :
                          Problem("Entity set 'BancoContext.Funcionario'  is null.");
        }

        // GET: FuncionarioModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Funcionario == null)
            {
                return NotFound();
            }

            var funcionarioModel = await _context.Funcionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionarioModel == null)
            {
                return NotFound();
            }

            return View(funcionarioModel);
        }

        // GET: FuncionarioModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FuncionarioModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Login,Senha,Email,Cpf,DataDeNascimento,Rg,EstadoCivil,Endereco,Telefone,Pis,Cargo,Departamento,SalarioContratual,DataDeAdmissão,Nacionalidade,Sexo,HorasTrabalhadas,NomeDoBanco,Agencia,Conta,TipoDeConta,DataAtualizacao")] FuncionarioModel funcionarioModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(funcionarioModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funcionarioModel);
        }

        // GET: FuncionarioModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Funcionario == null)
            {
                return NotFound();
            }

            var funcionarioModel = await _context.Funcionario.FindAsync(id);
            if (funcionarioModel == null)
            {
                return NotFound();
            }
            return View(funcionarioModel);
        }

        // POST: FuncionarioModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Login,Senha,Email,Cpf,DataDeNascimento,Rg,EstadoCivil,Endereco,Telefone,Pis,Cargo,Departamento,SalarioContratual,DataDeAdmissão,Nacionalidade,Sexo,HorasTrabalhadas,NomeDoBanco,Agencia,Conta,TipoDeConta,DataAtualizacao")] FuncionarioModel funcionarioModel)
        {
            if (id != funcionarioModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funcionarioModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuncionarioModelExists(funcionarioModel.Id))
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
            return View(funcionarioModel);
        }

        // GET: FuncionarioModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Funcionario == null)
            {
                return NotFound();
            }

            var funcionarioModel = await _context.Funcionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funcionarioModel == null)
            {
                return NotFound();
            }

            return View(funcionarioModel);
        }

        // POST: FuncionarioModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Funcionario == null)
            {
                return Problem("Entity set 'BancoContext.Funcionario'  is null.");
            }
            var funcionarioModel = await _context.Funcionario.FindAsync(id);
            if (funcionarioModel != null)
            {
                _context.Funcionario.Remove(funcionarioModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuncionarioModelExists(int id)
        {
          return (_context.Funcionario?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
