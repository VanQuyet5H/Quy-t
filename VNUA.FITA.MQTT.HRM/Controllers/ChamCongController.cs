using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VNUA.FITA.MQTT.HRM.Data.Access;
using VNUA.FITA.MQTT.HRM.Data.Model;

namespace VNUA.FITA.MQTT.HRM.Controllers
{
    public class ChamCongController : Controller
    {
        private readonly SqlServerDbContext _context;

        public ChamCongController(SqlServerDbContext context)
        {
            _context = context;
        }

        // GET: ChamCong
        public async Task<IActionResult> Index()
        {
            var sqlServerDbContext = _context.ChamCongs.Include(c => c.NhanViens);
            return View(await sqlServerDbContext.ToListAsync());
        }

        // GET: ChamCong/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamCong = await _context.ChamCongs
                .Include(c => c.NhanViens)
                .FirstOrDefaultAsync(m => m.IdCong == id);
            if (chamCong == null)
            {
                return NotFound();
            }

            return View(chamCong);
        }

        // GET: ChamCong/Create
        public IActionResult Create()
        {
            ViewData["IdNhanVien"] = new SelectList(_context.NhanViens, "IdNhanVien", "IdNhanVien");
            return View();
        }

        // POST: ChamCong/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCong,ThoiGian,TrangThai,GhiChu,IdNhanVien")] ChamCong chamCong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chamCong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdNhanVien"] = new SelectList(_context.NhanViens, "IdNhanVien", "IdNhanVien", chamCong.IdNhanVien);
            return View(chamCong);
        }

        // GET: ChamCong/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamCong = await _context.ChamCongs.FindAsync(id);
            if (chamCong == null)
            {
                return NotFound();
            }
            ViewData["IdNhanVien"] = new SelectList(_context.NhanViens, "IdNhanVien", "IdNhanVien", chamCong.IdNhanVien);
            return View(chamCong);
        }

        // POST: ChamCong/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCong,ThoiGian,TrangThai,GhiChu,IdNhanVien")] ChamCong chamCong)
        {
            if (id != chamCong.IdCong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chamCong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChamCongExists(chamCong.IdCong))
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
            ViewData["IdNhanVien"] = new SelectList(_context.NhanViens, "IdNhanVien", "IdNhanVien", chamCong.IdNhanVien);
            return View(chamCong);
        }

        // GET: ChamCong/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chamCong = await _context.ChamCongs
                .Include(c => c.NhanViens)
                .FirstOrDefaultAsync(m => m.IdCong == id);
            if (chamCong == null)
            {
                return NotFound();
            }

            return View(chamCong);
        }

        // POST: ChamCong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var chamCong = await _context.ChamCongs.FindAsync(id);
            _context.ChamCongs.Remove(chamCong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChamCongExists(int id)
        {
            return _context.ChamCongs.Any(e => e.IdCong == id);
        }
    }
}
