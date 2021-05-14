using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrackFittNumberTwo.Models;

namespace TrackFittNumberTwo.Controllers
{
    public class MacronutrientMeasurementsController : Controller
    {
        private readonly TrackFittDataBase_2Context _context;

        public MacronutrientMeasurementsController(TrackFittDataBase_2Context context)
        {
            _context = context;
        }

        // GET: MacronutrientMeasurements
        public async Task<IActionResult> Index()
        {
            return View(await _context.MacronutrientMeasurements.ToListAsync());
        }

        // GET: MacronutrientMeasurements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var macronutrientMeasurement = await _context.MacronutrientMeasurements
                .FirstOrDefaultAsync(m => m.FoodId == id);
            if (macronutrientMeasurement == null)
            {
                return NotFound();
            }

            return View(macronutrientMeasurement);
        }

        // GET: MacronutrientMeasurements/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MacronutrientMeasurements/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FoodId,FoodName,Calories,Fat,Carbs,Protein,Sugar")] MacronutrientMeasurement macronutrientMeasurement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(macronutrientMeasurement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(macronutrientMeasurement);
        }

        // GET: MacronutrientMeasurements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var macronutrientMeasurement = await _context.MacronutrientMeasurements.FindAsync(id);
            if (macronutrientMeasurement == null)
            {
                return NotFound();
            }
            return View(macronutrientMeasurement);
        }

        // POST: MacronutrientMeasurements/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FoodId,FoodName,Calories,Fat,Carbs,Protein,Sugar")] MacronutrientMeasurement macronutrientMeasurement)
        {
            if (id != macronutrientMeasurement.FoodId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(macronutrientMeasurement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MacronutrientMeasurementExists(macronutrientMeasurement.FoodId))
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
            return View(macronutrientMeasurement);
        }

        // GET: MacronutrientMeasurements/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var macronutrientMeasurement = await _context.MacronutrientMeasurements
                .FirstOrDefaultAsync(m => m.FoodId == id);
            if (macronutrientMeasurement == null)
            {
                return NotFound();
            }

            return View(macronutrientMeasurement);
        }

        // POST: MacronutrientMeasurements/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var macronutrientMeasurement = await _context.MacronutrientMeasurements.FindAsync(id);
            _context.MacronutrientMeasurements.Remove(macronutrientMeasurement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MacronutrientMeasurementExists(int id)
        {
            return _context.MacronutrientMeasurements.Any(e => e.FoodId == id);
        }
    }
}
