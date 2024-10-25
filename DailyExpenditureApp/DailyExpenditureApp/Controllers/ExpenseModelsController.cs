﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DailyExpenditureApp.Models;

namespace DailyExpenditureApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseModelsController : ControllerBase
    {
        private readonly ExpenseDetailContext _context;

        public ExpenseModelsController(ExpenseDetailContext context)
        {
            _context = context;
        }

        // GET: api/ExpenseModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExpenseModel>>> GetExpenses()
        {
            return await _context.Expenses.ToListAsync();
        }

        // GET: api/ExpenseModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ExpenseModel>> GetExpenseModel(Guid id)
        {
            var expenseModel = await _context.Expenses.FindAsync(id);

            if (expenseModel == null)
            {
                return NotFound();
            }

            return expenseModel;
        }

        // PUT: api/ExpenseModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpenseModel(Guid id, ExpenseModel expenseModel)
        {
            if (id != expenseModel.ExpenseID)
            {
                return BadRequest();
            }

            _context.Entry(expenseModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ExpenseModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ExpenseModel>> PostExpenseModel(ExpenseModel expenseModel)
        {
            _context.Expenses.Add(expenseModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExpenseModel", new { id = expenseModel.ExpenseID }, expenseModel);
        }

        // DELETE: api/ExpenseModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpenseModel(Guid id)
        {
            var expenseModel = await _context.Expenses.FindAsync(id);
            if (expenseModel == null)
            {
                return NotFound();
            }

            _context.Expenses.Remove(expenseModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExpenseModelExists(Guid id)
        {
            return _context.Expenses.Any(e => e.ExpenseID == id);
        }
    }
}
