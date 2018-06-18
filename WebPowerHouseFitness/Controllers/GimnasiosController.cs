﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPowerHouseFitness.Data;
using WebPowerHouseFitness.Models;

namespace WebPowerHouseFitness.Controllers
{
    public class GimnasiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GimnasiosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Gimnasios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gimnasio.ToListAsync());
        }

        // GET: Gimnasios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gimnasio = await _context.Gimnasio
                .SingleOrDefaultAsync(m => m.ID == id);
            if (gimnasio == null)
            {
                return NotFound();
            }

            return View(gimnasio);
        }

        // GET: Gimnasios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gimnasios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Direccion,País,Ciudad")] Gimnasio gimnasio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gimnasio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gimnasio);
        }

        // GET: Gimnasios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gimnasio = await _context.Gimnasio.SingleOrDefaultAsync(m => m.ID == id);
            if (gimnasio == null)
            {
                return NotFound();
            }
            return View(gimnasio);
        }

        // POST: Gimnasios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Direccion,País,Ciudad")] Gimnasio gimnasio)
        {
            if (id != gimnasio.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gimnasio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GimnasioExists(gimnasio.ID))
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
            return View(gimnasio);
        }

        // GET: Gimnasios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gimnasio = await _context.Gimnasio
                .SingleOrDefaultAsync(m => m.ID == id);
            if (gimnasio == null)
            {
                return NotFound();
            }

            return View(gimnasio);
        }

        // POST: Gimnasios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gimnasio = await _context.Gimnasio.SingleOrDefaultAsync(m => m.ID == id);
            _context.Gimnasio.Remove(gimnasio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GimnasioExists(int id)
        {
            return _context.Gimnasio.Any(e => e.ID == id);
        }
    }
}
