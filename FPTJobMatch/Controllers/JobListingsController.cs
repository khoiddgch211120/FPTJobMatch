using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FPTJobMatch.Data;
using FPTJobMatch.Models;
using Microsoft.AspNetCore.Identity;

namespace FPTJobMatch.Controllers
{
    public class JobListingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public JobListingsController(UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: JobListings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.JobListing.Include(j => j.Location);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: JobListings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobListing = await _context.JobListing
                .Include(j => j.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobListing == null)
            {
                return NotFound();
            }

            return View(jobListing);
        }

        // GET: JobListings/Create
        public IActionResult Create()
        {
            ViewData["LocationId"] = new SelectList(_context.Location, "Id", "LocationName");
            return View();
        }

        // POST: JobListings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Description,CompanyName,Position,Salary,LocationId,UserId")] JobListing jobListing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobListing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationId"] = new SelectList(_context.Location, "Id", "Id", jobListing.LocationId);
            return View(jobListing);
        }

        // GET: JobListings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobListing = await _context.JobListing.FindAsync(id);
            if (jobListing == null)
            {
                return NotFound();
            }
            ViewData["LocationId"] = new SelectList(_context.Location, "Id", "Id", jobListing.LocationId);
            return View(jobListing);
        }

        // POST: JobListings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,CompanyName,Position,Salary,LocationId,UserId")] JobListing jobListing)
        {
            if (id != jobListing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobListing);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobListingExists(jobListing.Id))
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
            ViewData["LocationId"] = new SelectList(_context.Location, "Id", "Id", jobListing.LocationId);
            return View(jobListing);
        }

        // GET: JobListings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobListing = await _context.JobListing
                .Include(j => j.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobListing == null)
            {
                return NotFound();
            }

            return View(jobListing);
        }

        // POST: JobListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobListing = await _context.JobListing.FindAsync(id);
            _context.JobListing.Remove(jobListing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobListingExists(int id)
        {
            return _context.JobListing.Any(e => e.Id == id);
        }
        [HttpPost]
        public async Task<IActionResult> Search(string model)
        {
            var jobs = _context.JobListing.Include(j => j.Position).Where(lap => lap.Salary.Contains(model));
            return View("List", await jobs.ToListAsync());
        }

        public async Task<IActionResult> SortPriceAsc()
        {
            var jobs = _context.JobListing.Include(j => j.Position).OrderBy(lap => lap.Salary);
            return View("List", await jobs.ToListAsync());
        }

        public async Task<IActionResult> SortPriceDesc()
        {
            var jobs = _context.JobListing.Include(j => j.Position).OrderByDescending(lap => lap.Salary);
            return View("List", await jobs.ToListAsync());
        }
    }
}
