﻿using DOANCuoiKyNET.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOANCuoiKyNET.Session;
using DOANCuoiKyNET.Models;
using System.Net;

namespace DOANCuoiKyNET.Controllers
{
    public class LoginController : Controller


    {

        private readonly MyDBContext _context;

        public LoginController(MyDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            if (ssuser != null)
            {
                ViewBag.houser = ssuser.hoUser;
                ViewBag.tenuser = ssuser.tenUser;
                ViewBag.accmenu1 = "Thông tin cá nhân";
                ViewBag.accmenu2 = "Đơn mua";
                ViewBag.accmenu3 = "Thoát";
                if (ssuser.vaitro == "admin")
                {
                    ViewBag.accmenu4 = "Trang quản trị";
                }else if (ssuser.vaitro=="staff")
                {
                    ViewBag.accmenu4 = "Trang nhân viên";
                }
            }
            else
            {
                ViewBag.houser = "TÀI";
                ViewBag.tenuser = "KHOẢN";
                ViewBag.accmenu1 = "Đăng nhập";
            }
            if (ssuser != null)
            {
                return RedirectToAction("index", "Home");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
           sessionuser sessionuser = Logoutss;
            HttpContext.Session.Set("ssuser", sessionuser);

            return View();
        }
    
        public sessionuser Logoutss
        {
            get
            {
                var data = HttpContext.Session.Get<sessionuser>("ssuser");
                if (data != null)
                {
                    data = null;
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
        public async Task<IActionResult> Verify(string email, string mkhau,string x)
        {
          //  var myssuser = ssuser;

            var dsAcc = _context.Users
                .SingleOrDefault(acc => (acc.emailUser == email && acc.matKhau == mkhau) || (acc.sdtUser == email && acc.matKhau == mkhau));
            if(dsAcc!=null){
                /*
                                IPHostEntry iphost = Dns.GetHostEntry(Dns.GetHostName());
                                string ipadd = Convert.ToString(iphost.AddressList.FirstOrDefault(address => address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork));
                */
                var dsIp = _context.IPusers
                    .SingleOrDefault(ipp => (ipp.idUser == dsAcc.idUser && ipp.diachiip == x));
                if (dsIp == null)
                {
                        IPuser puser = new IPuser();
                        puser.diachiip = x;
                        puser.idUser = dsAcc.idUser;

                        _context.Add(puser);
                        await _context.SaveChangesAsync();

                }
                

                var admins
    = from p in _context.Users
      join c in _context.QuanTris on p.idUser equals c.idUser
      where p.emailUser == email
      select new
      {
          tenUser = p.tenUser,

      };
                if (admins.Count() == 1)
                {
                    var item =
                              new sessionuser
                              {

                                  idUser = dsAcc.idUser,
                                  hoUser = dsAcc.hoUser,
                                  tenUser = dsAcc.tenUser,
                                  sdtUser = dsAcc.sdtUser,
                                  emailUser = dsAcc.emailUser,
                                  gioiTinh = dsAcc.gioiTinh,
                                  ngaySinh = dsAcc.ngaySinh.ToString(),
                                  diaChi = dsAcc.diaChi,
                                  hinhAVT = dsAcc.hinhAVT,
                                  vaitro = "admin",
                              };

                    HttpContext.Session.Set("ssuser", item);
                    ViewBag.mess = "admins";
                    return View();
                }
                else
                {
                    var staffs
                = from p in _context.Users
                  join c in _context.NhanViens on p.idUser equals c.idUser
                  where p.emailUser == email
                  select new
                  {
                      tenUser = p.tenUser,

                  };
                    if (staffs.Count() == 1)
                    {
                        var item =
                             new sessionuser
                             {

                                 idUser = dsAcc.idUser,
                                 hoUser = dsAcc.hoUser,
                                 tenUser = dsAcc.tenUser,
                                 sdtUser = dsAcc.sdtUser,
                                 emailUser = dsAcc.emailUser,
                                 gioiTinh = dsAcc.gioiTinh,
                                 ngaySinh = dsAcc.ngaySinh.ToString(),
                                 diaChi = dsAcc.diaChi,
                                 hinhAVT = dsAcc.hinhAVT,
                                 vaitro = "staffs",
                             };

                        HttpContext.Session.Set("ssuser", item);
                        ViewBag.mess = "staffs";
                        return View();
                    }
                    else
                    {
                        var item =
                             new sessionuser
                             {

                                 idUser = dsAcc.idUser,
                                 hoUser = dsAcc.hoUser,
                                 tenUser = dsAcc.tenUser,
                                 sdtUser = dsAcc.sdtUser,
                                 emailUser = dsAcc.emailUser,
                                 gioiTinh = dsAcc.gioiTinh,
                                 ngaySinh = dsAcc.ngaySinh.ToString(),
                                 diaChi = dsAcc.diaChi,
                                 hinhAVT = dsAcc.hinhAVT,
                                 vaitro = "users",
                             };

                        HttpContext.Session.Set("ssuser", item);
                        ViewBag.mess = "users";
                        return View();
                    }
                }



            }
           
           
         
            else
            {
                var test = _context.Users
                .Where(acc => acc.emailUser == email )

                .Select(p => new User
                {
                    idUser = p.idUser,
                
                });
                if (test.Count() == 1)
                {
                    ViewBag.mess = "Mật khẩu không đúng!";
                    return View();
                }
                else {
                    ViewBag.mess = "Tài khoản không tồn tại!";
                   return View();
                }
                
            }
            
            
        }
    }
}
