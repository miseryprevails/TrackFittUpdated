using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrackFittNumberTwo.Models;
using Microsoft.IdentityModel;

namespace TrackFittNumberTwo.Controllers
{
    public class AccountInfoesController : Controller
    {
        private readonly TrackFittDataBase_2Context _context;

        public AccountInfoesController(TrackFittDataBase_2Context context)
        {
            _context = context;
        }

        // GET: AccountInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.AccountInfos.ToListAsync());
        }

        // GET: AccountInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountInfo = await _context.AccountInfos
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (accountInfo == null)
            {
                return NotFound();
            }

            return View(accountInfo);
        }

        // GET: AccountInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,FirstName,LastName,Email,UserPassword,Height,Weight,Age")] AccountInfo accountInfo)
        {
            if (ModelState.IsValid)
            {
                
                _context.Add(accountInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                
            }
            return View(accountInfo);
        }

       
        // GET: AccountInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountInfo = await _context.AccountInfos.FindAsync(id);
            if (accountInfo == null)
            {
                return NotFound();
            }
            return View(accountInfo);
        }

        // POST: AccountInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FirstName,LastName,Email,UserPassword,Height,Weight,Age")] AccountInfo accountInfo)
        {
            if (id != accountInfo.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountInfoExists(accountInfo.UserId))
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
            return View(accountInfo);
        }

        // GET: AccountInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountInfo = await _context.AccountInfos
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (accountInfo == null)
            {
                return NotFound();
            }

            return View(accountInfo);
        }

        // POST: AccountInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountInfo = await _context.AccountInfos.FindAsync(id);
            _context.AccountInfos.Remove(accountInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountInfoExists(int id)
        {
            return _context.AccountInfos.Any(e => e.UserId == id);
        }
    }
}
