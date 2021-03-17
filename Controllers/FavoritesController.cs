using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EMF.Contexts;
using EMF.Models;

namespace EMF.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly FavoritesDbContext _context;

        public FavoritesController(FavoritesDbContext context)
        {
            _context = context;
        }

        // GET: Favorites
        public async Task<IActionResult> Index()
        {
            return View(await _context.Favorites.ToListAsync());
        }

        // GET: Favorites/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favorite = await _context.Favorites
                .FirstOrDefaultAsync(m => m.Id == id);
            if (favorite == null)
            {
                return NotFound();
            }

            return View(favorite);
        }






        // GET: Favorites/Create
        public IActionResult Create()
        {
            return View();
        }


        public async Task<bool> SaveToFavorites(string id, string verse)
        {
            if(!string.IsNullOrEmpty(id) && !FavoriteExists(id))
            {
                try
                {
                    var newFavorite = new Favorite();
                    newFavorite.EmfId = id;
                    newFavorite.Verse = verse;

                    _context.Add(newFavorite);
                    await _context.SaveChangesAsync();

                    return true;
                }
                catch(Exception e)
                {
                    return false;
                }

            }
            return false;
        }



        // POST: Favorites/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmfId,Verse")] Favorite favorite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(favorite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(favorite);
        }






        // GET: Favorites/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var favorite = await _context.Favorites.FindAsync(id);
            if (favorite == null)
            {
                return NotFound();
            }
            return View(favorite);
        }

        // POST: Favorites1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,EmfId,Verse")] Favorite favorite)
        {
            if (id != favorite.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(favorite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FavoriteExists(favorite.Id))
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
            return View(favorite);
        }


        
        public async Task<IActionResult> Delete(string id)
        {
            var fav = await _context.Favorites.FindAsync(id);
            if (fav == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.Favorites.Remove(fav);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.)
                // return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
                return RedirectToAction(nameof(Index), new { id = id, saveChangesError = true });
            }
        }



        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var student = await _context.Favorites.FindAsync(id);
        //    if (student == null)
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }

        //    try
        //    {
        //        _context.Favorites.Remove(student);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch (DbUpdateException /* ex */)
        //    {
        //        //Log the error (uncomment ex variable name and write a log.)
        //       // return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
        //        return RedirectToAction(nameof(Index), new { id = id, saveChangesError = true });
        //    }
        //}

        private bool FavoriteExists(string id)
        {
            return _context.Favorites.Any(e => e.EmfId == id);         
        }
    }
}
