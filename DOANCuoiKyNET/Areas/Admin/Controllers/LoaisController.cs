﻿using DOANCuoiKyNET.Entities;
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
        public IActionResult Index()
        {
            var loaisp
                = from p in _context.LoaiSPs
                  join c in _context.Users on p.idUser equals c.idUser
                  // where p.ProductId == 2
                  select new User_Loai
                  {
                      idLoaiSP = p.idLoaiSP,
                      hinhAnh = p.hinhAnh,
                 tenLoaiSP = p.tenLoaiSP,
                
                 metaTitle = p.metaTitle,
                 trangThai = p.trangThai,
                 ngayTao = p.ngayTao,
                 ngayCapNhat = p.ngayCapNhat,
                 hoUser =c.hoUser,
                 tenUser = c.tenUser
                  };

            
            return View(loaisp);
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
        public async Task<IActionResult> Create(LoaiSP loai, IFormFile hinhAnh)
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
                    
                    var urlfull = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","images","loaisp",s);
                    using (var file = new FileStream(urlfull, FileMode.Create))
                    {
                        await hinhAnh.CopyToAsync(file);
                    }

                     loai.hinhAnh = s;
                }

                loai.idUser = ssuser.idUser;

               
                loai.ngayTao = DateTime.Now;
                loai.ngayCapNhat = DateTime.Now;
                _context.Add(loai);
                await _context.SaveChangesAsync();
             //   return RedirectToAction(nameof(Index));

            }
            return RedirectToAction("Index");
            
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


      [HttpPost]
        public IActionResult TimAjax(string keyword)
        {
       
            if (!string.IsNullOrEmpty(keyword))
            {
               var  dsLoai = from p in _context.LoaiSPs
                        join c in _context.Users on p.idUser equals c.idUser
                        where p.tenLoaiSP.Contains(keyword) || p.metaTitle.Contains(keyword)
                       select new User_Loai
                        {
                            idLoaiSP = p.idLoaiSP,
                            hinhAnh = p.hinhAnh,
                            tenLoaiSP = p.tenLoaiSP,
                            
                            metaTitle = p.metaTitle,
                            trangThai = p.trangThai,
                            ngayTao = p.ngayTao,
                            ngayCapNhat = p.ngayCapNhat,
                            hoUser = c.hoUser,
                            tenUser = c.tenUser
                        };
                return PartialView(dsLoai);

            }

            var dsLoai2 = from p in _context.LoaiSPs
                         join c in _context.Users on p.idUser equals c.idUser
                        // where p.tenLoaiSP.Contains(keyword) || p.metaTitle.Contains(keyword)
                         select new User_Loai
                         {
                             idLoaiSP = p.idLoaiSP,
                             hinhAnh = p.hinhAnh,
                             tenLoaiSP = p.tenLoaiSP,
                            
                             metaTitle = p.metaTitle,
                             trangThai = p.trangThai,
                             ngayTao = p.ngayTao,
                             ngayCapNhat = p.ngayCapNhat,
                             hoUser = c.hoUser,
                             tenUser = c.tenUser
                         };






            return PartialView(dsLoai2);
        }


        private bool  LoaiSPExists(int id)
        {
            return _context.LoaiSPs.Any(e => e.idLoaiSP == id);
        }


    }
}
