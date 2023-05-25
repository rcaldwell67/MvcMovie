using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class WagersController : Controller
    {
        private readonly MvcMovieContext _context;

        public WagersController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: Wagers
        public async Task<IActionResult> Index(string movieGenre, string searchString)
        {
            if (_context.Wager == null)
            {
                return Problem("Entity set 'MvcMovieContext.Wager'  is null.");
            }

            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Wager
                                            orderby m.GameDate
                                            select m.Type;
            var wagers = from m in _context.Wager
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                wagers = wagers.Where(s => s.Side!.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                wagers = wagers.Where(x => x.Side == movieGenre);
            }

            var movieGenreVM = new WagerViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Wagers = await wagers.ToListAsync()
            };

            return View(movieGenreVM);
        }

        // GET: Wagers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Wager == null)
            {
                return NotFound();
            }

            var wager = await _context.Wager
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wager == null)
            {
                return NotFound();
            }

            return View(wager);
        }

        // GET: Wagers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wagers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameDate1,GameDate2,GameDate3,GameDate4," +
            "GameTime1,GameTime2,GameTime3,GameTime4,Type,Side,Odds1,Odds2,Odds3,Odd4," +
            "DecOdds,DecOdds1,DecOdds2,DecOdds3,DecOdds4," +
            "Bet,Win,Payout,Leg1,Leg2,Leg3,Leg4,Leg,Legs,Winner,Profit,Outcome,Result")] Wager wager)
        {
            try
            {
                wager.Odds = null;
                if (ModelState.IsValid)
                {
                    _context.Add(wager);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {

            }
            return View(wager);
        }

        // GET: Wagers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Wager == null)
            {
                return NotFound();
            }

            var wager = await _context.Wager.FindAsync(id);
            if (wager == null)
            {
                return NotFound();
            }
            return View(wager);
        }

        // POST: Wagers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameDate,GameTime,Type,Side,Odds,DecOdds," +
            "Bet,Win,Payout,Leg,Leg,Legs,Winner,Profit,Outcome,Result")] Wager wager)
        {
            if (id != wager.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wager);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(wager.Id))
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
            return View(wager);
        }

        // GET: Wagers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Wager == null)
            {
                return NotFound();
            }

            var wager = await _context.Wager
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wager == null)
            {
                return NotFound();
            }

            return View(wager);
        }

        // POST: Wagers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Wager == null)
            {
                return Problem("Entity set 'MvcMovieContext.Wager'  is null.");
            }
            var wager = await _context.Wager.FindAsync(id);
            if (wager != null)
            {
                _context.Wager.Remove(wager);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Wagers/Calculator
        public IActionResult Calculator()
        {
            return View();
        }

        private bool MovieExists(int id)
        {
          return (_context.Wager?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
