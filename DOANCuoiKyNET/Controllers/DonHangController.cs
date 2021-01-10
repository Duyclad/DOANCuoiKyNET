using DOANCuoiKyNET.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Controllers
{
    public class DonHangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        private readonly MyDBContext _context;

        public DonHangController(MyDBContext context)
        {
            _context = context;
        }


        public IActionResult TraCuu(int id)
        {
            var dh = _context.DonHangs.FirstOrDefault(p => p.idDH == id);


            return View(dh);
        }

        public IActionResult LichSuDonHang()
        {
            var dh = _context.DonHangs;


            return View(dh);
        }

        public IActionResult LichSuDonHang(int? id)
        {
            var dh = _context.DonHangs.FirstOrDefault(p => p.idDH == id);


            return View(dh);
        }


    }
}
