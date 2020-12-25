using DOANCuoiKyNET.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            return View();
        }

        [HttpPost]
        public IActionResult Verify(string email, string mkhau)
        {
            var dsAcc = _context.Users
                .Where(acc => (acc.emailUser == email  && acc.matKhau==mkhau) || (acc.sdtUser == email && acc.matKhau == mkhau))
               
                .Select(p => new User
                {
                    idUser = p.idUser,
                    hoUser = p.hoUser,
                    tenUser = p.tenUser,
                    sdtUser = p.sdtUser,
                    emailUser = p.emailUser,
                    matKhau = p.matKhau,
                    diaChi = p.diaChi,
                    hinhAVT = p.hinhAVT
                }) ;
            if (dsAcc.Count() == 0)
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
            else
            {
                

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
                    ViewBag.mess = "admins";
                    return View();
                }
                else 
                {
                    var staffs
                = from p in _context.Users
                  join c in _context.QuanTris on p.idUser equals c.idUser
                  where p.emailUser == email
                  select new
                  {
                      tenUser = p.tenUser,

                  };
                    if (staffs.Count()==1)
                    {
                        ViewBag.mess = "staffs";
                        return View();
                    }
                        else
                            {
                                ViewBag.mess = "users";
                                return View();
                            }
                }
                
                
            }
            
        }
    }
}
