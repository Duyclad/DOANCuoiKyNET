using DOANCuoiKyNET.Entities;
using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace DOANCuoiKyNET.Controllers
{
    [Area("Admin")]
    public class LoaisController : Controller
    {
      /*  public IActionResult Index()
        {
            return View();
        }*/
        private readonly MyDBContext _context;

        public LoaisController (MyDBContext context)
        {
            _context = context;
        }

        //GET Loais
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiSPs.ToListAsync());
        }

        //GET Loais/Details/5

        public async Task<IActionResult> Details (int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var loai = await _context.LoaiSPs
                .FirstOrDefaultAsync(m => m.idLoaiSP == id);
            if (loai == null)
            {
                return NotFound();
            }
            return View(loai);
        }

        // GET: Loais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Loais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idLoaiSP,tenLoaiSP,hinhAnh,metaTitle,trangThai,ngayTao,ngayCapNhat,idUser")] LoaiSP loai, IFormFile hinhAnh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loai);
        }

        // GET: Loais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai = await _context.LoaiSPs.FindAsync(id);
            if (loai == null)
            {
                return NotFound();
            }
            return View(loai);
        }

        // POST: Loais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idLoaiSP,tenLoaiSP,hinhAnh,metaTitle,trangThai,ngayTao,ngayCapNhat,idUser")] LoaiSP loai)
        {
            if (id != loai.idLoaiSP)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                   if (!LoaiSPExists(loai.idLoaiSP))
                  
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
            return View(loai);
        }

        // GET: Loais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loai = await _context.LoaiSPs
                .FirstOrDefaultAsync(m => m.idLoaiSP == id);
            if (loai == null)
            {
                return NotFound();
            }

            return View(loai);
        }

        // POST: Loais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loai = await _context.LoaiSPs.FindAsync(id);
            //_context.Loais.Remove(loai);
            _context.Remove(loai);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        private bool  LoaiSPExists(int id)
        {
            return _context.LoaiSPs.Any(e => e.idLoaiSP == id);
        }
    }
}
