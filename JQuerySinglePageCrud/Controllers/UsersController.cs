using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JQuerySinglePageCrud.Data;
using JQuerySinglePageCrud.Models;
using System.Threading;

namespace JQuerySinglePageCrud.Controllers
{
    public class UsersController : Controller
    {
        private readonly JQuerySinglePageCrudContext _context;

        public UsersController(JQuerySinglePageCrudContext context)
        {
            _context = context;
            Thread.Sleep(500);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataTable()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return Unauthorized();
        }

        // GET: Users
        public async Task<IActionResult> List()
        {
            return View(await _context.User.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // GET: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                var _user = _context.User
                    .FirstOrDefault(u => u.Username == user.Username);

                if (_user != null)
                {
                    ModelState.AddModelError(nameof(user.Username), "This user already exist.");
                    return View(user);
                }

                _context.Add(user);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "User created successfully";
                return RedirectToAction("Details", new { id = user.ID });
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, User user)
        {
            if (id != user.ID)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                TempData["SuccessMessage"] = "User updated successfully";
                return View(user);
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User
                .FirstOrDefaultAsync(m => m.ID == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            _context.User.Remove(user);
            await _context.SaveChangesAsync();
            TempData["SuccessMessage"] = "User deleted successfully";
            user.ID = 0;
            return View(user);
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}
