using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private readonly InsuranceContext _context;

        public InsureeController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: Insuree
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // GET: Insuree/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // GET: Insuree/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // Calculate the quote before saving
                insuree.Quote = CalculateQuote(insuree);

                _context.Add(insuree);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree == null)
            {
                return NotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (id != insuree.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    // Recalculate the quote before updating
                    insuree.Quote = CalculateQuote(insuree);

                    _context.Update(insuree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InsureeExists(insuree.Id))
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
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var insuree = await _context.Insurees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (insuree == null)
            {
                return NotFound();
            }

            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var insuree = await _context.Insurees.FindAsync(id);
            if (insuree != null)
            {
                _context.Insurees.Remove(insuree);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Insuree/Admin
        public async Task<IActionResult> Admin()
        {
            var insurees = await _context.Insurees.ToListAsync();
            return View(insurees);
        }

        private bool InsureeExists(int id)
        {
            return _context.Insurees.Any(e => e.Id == id);
        }

        // Quote Calculation Logic
        private decimal CalculateQuote(Insuree insuree)
        {
            // Start with base monthly rate
            decimal quote = 50m;

            // Calculate age
            var today = DateTime.Today;
            var age = today.Year - insuree.DateOfBirth.Year;
            if (insuree.DateOfBirth.Date > today.AddYears(-age)) age--;

            // Age-based pricing
            if (age <= 18)
            {
                quote += 100m;
            }
            else if (age >= 19 && age <= 25)
            {
                quote += 50m;
            }
            else if (age >= 26)
            {
                quote += 25m;
            }

            // Car year pricing
            if (insuree.CarYear < 2000)
            {
                quote += 25m;
            }
            else if (insuree.CarYear > 2015)
            {
                quote += 25m;
            }

            // Car make pricing
            if (insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25m;
                // Extra for Porsche 911 Carrera
                if (insuree.CarModel.ToLower().Contains("911") && insuree.CarModel.ToLower().Contains("carrera"))
                {
                    quote += 25m;
                }
            }

            // Speeding tickets pricing
            quote += insuree.SpeedingTickets * 10m;

            // DUI pricing (25% increase)
            if (insuree.DUI)
            {
                quote *= 1.25m;
            }

            // Full coverage pricing (50% increase)
            if (insuree.CoverageType)
            {
                quote *= 1.5m;
            }

            return Math.Round(quote, 2);
        }
    }
}