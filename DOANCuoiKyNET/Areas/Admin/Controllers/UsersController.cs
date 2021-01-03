using DOANCuoiKyNET.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        


        private readonly MyDBContext _context;

        public UsersController(MyDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            

            return View(_context.Users);
        }

        [HttpPost]
        public IActionResult TimAjax(string keyword)
        {

            if (!string.IsNullOrEmpty(keyword))
            {
                var dsLoai = from p in _context.LoaiSPs
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




    }
}
