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
    public class Master_FoodController : Controller
    {
        private readonly TrackFittDataBase_2Context _context;

        public Master_FoodController(TrackFittDataBase_2Context context)
        {
            _context = context;
        }

        // GET: Master_Food
        public async Task<IActionResult> Index()
        {
            return View(await _context.Master_Food.ToListAsync());
        }

        // GET: Master_Food/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var master_Food = await _context.Master_Food
                .FirstOrDefaultAsync(m => m.ID == id);
            if (master_Food == null)
            {
                return NotFound();
            }

            return View(master_Food);
        }

        // GET: Master_Food/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Master_Food/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Food_Group,Calories,Fat_g,Protein_g,Carbohydrate_g")] Master_Food master_Food)
        {
            if (ModelState.IsValid)
            {
                _context.Add(master_Food);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(master_Food);
        }

        // GET: Master_Food/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var master_Food = await _context.Master_Food.FindAsync(id);
            if (master_Food == null)
            {
                return NotFound();
            }
            return View(master_Food);
        }

        // POST: Master_Food/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Food_Group,Calories,Fat_g,Protein_g,Carbohydrate_g")] Master_Food master_Food)
        {
            if (id != master_Food.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(master_Food);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Master_FoodExists(master_Food.ID))
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
            return View(master_Food);
        }

        // GET: Master_Food/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var master_Food = await _context.Master_Food
                .FirstOrDefaultAsync(m => m.ID == id);
            if (master_Food == null)
            {
                return NotFound();
            }

            return View(master_Food);
        }

        // POST: Master_Food/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var master_Food = await _context.Master_Food.FindAsync(id);
            _context.Master_Food.Remove(master_Food);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            return 
        }

        private bool Master_FoodExists(int id)
        {
            return _context.Master_Food.Any(e => e.ID == id);
        }

        [HttpPost]
        public IActionResult Filter(string filterBy)
        {
            IEnumerable<Master_Food> newList = _context.Master_Food.Where(f => f.Name.Equals(filterBy));

            return View("Index", newList);
        }

        public async Task<IActionResult> Add(int? id)
        {
            if (id == null)
            {
                return View("Index");
            }

            //pulls the currently logged in user's email address
            //var userId = User.FindFirstValue(ClaimTypes.Name);

            //using the current user's email address, it it then used to find the user with that 
            // email address in the database. once found it returns the entire user object.
            //var currentUser = (User)_userManager.Users.Where(x => x.Email.Equals(userId)).Single
            
            // currentUser add fooditem with the id equal to id(from method) then add to user's meal table 

            return View("Index");
        }
    }
}
