using DOANCuoiKyNET.Entities;
using Microsoft.AspNetCore.Mvc;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using DOANCuoiKyNET.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Globalization;
using System.IO;
using DOANCuoiKyNET.Models;
using DOANCuoiKyNET.Session;


namespace DOANCuoiKyNET.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SanPhamsController : Controller
    {

        private readonly MyDBContext _context;

        public SanPhamsController(MyDBContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            var loaisp
                = from p in _context.LoaiSPs
                  join c in _context.SanPhams on p.idLoaiSP equals c.idLoaiSP
                  // where p.ProductId == 2
                  select new Sanpham_Loai
                  {
                      idSP = c.idSP,
                      tenSP = c.tenSP,
                      giaSP = c.giaSP,
                      hinhAnh = c.hinhAnh,
                      luotMua = c.luotMua,
                      luotXem=c.luotXem,
                      soLuongKho=c.soLuongKho,
                      moTa =c.moTa,
                      LoaiSP=p.tenLoaiSP,
                      trangThai=c.trangThai,
                      ngayTao=c.ngayTao,
                      ngayCapNhat=c.ngayCapNhat,
                      
                  };





            return View(loaisp);
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            /*
            var loai = await _context.LoaiSPs
                .FirstOrDefaultAsync(m => m.idLoaiSP == id);
            */


            var loaispx
               = from p in _context.LoaiSPs
                 join c in _context.SanPhams on p.idLoaiSP equals c.idLoaiSP
                 // where p.ProductId == 2
                 select new Sanpham_Loai
                 {
                     idSP = c.idSP,
                     tenSP = c.tenSP,
                     giaSP = c.giaSP,
                     hinhAnh = c.hinhAnh,
                     luotMua = c.luotMua,
                     luotXem = c.luotXem,
                     soLuongKho = c.soLuongKho,
                     moTa = c.moTa,
                     LoaiSP = p.tenLoaiSP,
                     trangThai = c.trangThai,
                     ngayTao = c.ngayTao,
                     ngayCapNhat = c.ngayCapNhat,

                 };





            if (loaispx == null)
            {
                return NotFound();
            }

            return View(loaispx);
        }

        // GET: Loais/Create
        public IActionResult Create()
        {
            return View();
        }

        public sessionuser ssuser
        {
            get
            {
                var data = HttpContext.Session.Get<sessionuser>("ssuser");
                /* if (data == null)
                  {
                      data = new sessionuser();
                  }*/
                return data;
            }
        }

        // POST: Loais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SanPham loai, IFormFile hinhAnh)
        {
            if (ModelState.IsValid)
            {
                if (hinhAnh != null)
                {
                    // DateTime hientai = DateTime.UtcNow;
                    // string htai = hientai.ToLongDateString();


                    string format = "yyyy_MM_dd_HH_mm_ss";

                    DateTime now = DateTime.Now;

                    string s = now.ToString(format) + ".jpg";

                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", "loaisp", s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                    loai.hinhAnh = s;
                }

              


                loai.ngayTao = DateTime.Now;
                loai.ngayCapNhat = DateTime.Now;
                _context.Add(loai);
                await _context.SaveChangesAsync();
                //   return RedirectToAction(nameof(Index));

            }
            return RedirectToAction("Index");

        }



    }
}
