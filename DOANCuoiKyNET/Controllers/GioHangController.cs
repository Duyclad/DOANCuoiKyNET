using DOANCuoiKyNET.Entities;
using DOANCuoiKyNET.Models;
using DOANCuoiKyNET.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Controllers
{
    public class GioHangController : Controller
    {
        public IActionResult Index()
        {
            return View(Carts);
        }

        public IActionResult AddTocart(int id,int sl)
        {
            
            if (sl == 0) { sl = 1; }
            var mycart = Carts;
            var item = mycart.SingleOrDefault(p => p.idSP == id);

            if (item == null)
            {
                var sp = _context.SanPhams.SingleOrDefault(p => p.idSP == id);
                item = new SSGioHang
                {

                    idSP = id,
                    tensp = sp.tenSP,
                    hinhAnh = sp.hinhAnh,
                    giasp = sp.giaSP,
                    soLuong = sl,
                };

                mycart.Add(item);
            }
            else
            {
                item.soLuong+=sl;
            }

            HttpContext.Session.Set("GioHang", mycart);
            return RedirectToAction("Index");
        }

        private readonly MyDBContext _context;

        public GioHangController(MyDBContext context)
        {
            _context = context;
        }

        public List<SSGioHang> Carts
        {
            get
            {
                var data = HttpContext.Session.Get<List<SSGioHang>>("GioHang");
                if (data == null)
                {
                    data = new List<SSGioHang>();
                }
                return data;
            }
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

        [HttpPost]
        public IActionResult AddTocartAjax(int id, int sl)
        {

            if (sl == 0) { sl = 1; }
            var mycart = Carts;
            var item = mycart.SingleOrDefault(p => p.idSP == id);

            if (item == null)
            {
                var sp = _context.SanPhams.SingleOrDefault(p => p.idSP == id);
                item = new SSGioHang
                {

                    idSP = id,
                    tensp = sp.tenSP,
                    hinhAnh = sp.hinhAnh,
                    giasp = sp.giaSP,
                    soLuong = sl,
                };

                mycart.Add(item);
            }
            else
            {
                item.soLuong += sl;
            }

            HttpContext.Session.Set("GioHang", mycart);
            return View();
        }

        [HttpPost]
        public IActionResult checkmgg(string id)
        {
            var mgg = _context.MaGiamGias
                .FirstOrDefault(p => p.codeMGG == id);
            if (mgg == null) {
                ViewBag.mess = "-1";
            }
            else
            {
                ViewBag.mess = mgg.giaTri;

            }


            return View();       
        }

        [HttpPost]
        public IActionResult tongtien()
        {

            ViewBag.mess = Carts.Sum(p => p.thanhTien);


            return View();
        }


        public IActionResult checkout(int mggvl, int tth, int tongcong)
        {

            ViewBag.mggvl = mggvl;
            ViewBag.tth = tth;
            ViewBag.tongcong = tongcong;
            if (ssuser != null)
            {
  ViewBag.ho = ssuser.hoUser;
            ViewBag.ten = ssuser.tenUser;
            ViewBag.email = ssuser.emailUser;
            ViewBag.sdt = ssuser.sdtUser;
            ViewBag.diachi = ssuser.diaChi;
            }
          


            return View();
        }



        public  IActionResult xacnhancheckout(int mggvl, int tth, int tongcong, string ho, string ten, string diachi, string email,string sdt, string ghichu )
        {
            

            DateTime xx = DateTime.Now;
            DonHang dh = new DonHang();
           
            dh.trangThai = "Đang xử lý";
            dh.ngayCapNhat = DateTime.Now;
            dh.ngayDat = DateTime.Now;
            dh.hoDH = ho;
            dh.tenDH = ten;
            dh.sdtDH = sdt;
            dh.diaChi = diachi;
            dh.eMail = email;
            dh.ghiChu = ghichu;
            dh.tongTienHang = tth;
            dh.tongSoTien = tongcong;
            dh.maGiamGiaDH = mggvl;

            _context.Add(dh);
            _context.SaveChangesAsync();





            

           
     
  //  var dhx = _context.DonHangs.FirstOrDefault(p => p.ngayDat == xx && p.hoDH == ho && p.tenDH == ten && p.sdtDH == sdt && p.eMail == email && p.diaChi == diachi);

            foreach (var item in Carts)
            {
                ChiTietDonHang xxx = new ChiTietDonHang();

                xxx.idDH = dh.idDH;
                xxx.tenSP = item.tensp;
                xxx.hinhSP = item.hinhAnh;
                xxx.donGia = item.giasp;
                xxx.soLuong = item.soLuong;
                xxx.thanhTien = item.thanhTien;
                _context.Add(xxx);
                _context.SaveChangesAsync();

            }

          
            Carts.Clear();

            HttpContext.Session.Set("GioHang", Carts);

            return RedirectToAction("index","giohang");
        }



        





    }
}
