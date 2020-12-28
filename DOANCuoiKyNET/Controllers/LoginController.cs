using DOANCuoiKyNET.Entities;
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


        public sessionuser tamp 
        {
            get
            {
                var data = HttpContext.Session.Get<sessionuser>("tamp");
                /* if (data == null)
                  {
                      data = new sessionuser();
                  }*/
                return data;
            }
        }

        public Models.MaXacNhan mxn
        {
            get
            {
                var data = HttpContext.Session.Get<Models.MaXacNhan>("mxns");
                /* if (data == null)
                  {
                      data = new sessionuser();
                  }*/
                return data;
            }
        }

        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }


        [HttpPost]
        public async Task<IActionResult> Verify(string email, string mkhau, string x)
        {
            //  var myssuser = ssuser;
            mkhau = GetMD5(mkhau).ToLower();
           
            var dsAcc = _context.Users
                .SingleOrDefault(acc => (acc.emailUser == email && acc.matKhau == mkhau) || (acc.sdtUser == email && acc.matKhau == mkhau));
            if (dsAcc != null) {
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
                .Where(acc => acc.emailUser == email)

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
     

        [HttpPost]
        public async Task<IActionResult> signup (string houser, string tenuser, string emailuser, string pwuser, string sdtuser, int gioiTinh,string ngaysinh,string x)
        {
            var dsus = _context.Users
                   .SingleOrDefault(ipp => (ipp.emailUser == emailuser));
            if (dsus != null)
            {
                ViewBag.mess = "1";
                return View();
            }

            DateTime myDate = DateTime.Parse(ngaysinh);
            var ips = new IPuser();
            if (ModelState.IsValid)
            {
                var users = new User();
                ips.diachiip = x;
                users.hinhAVT = "def.jpg";
                users.hoUser = houser;
                users.tenUser = tenuser;
                users.sdtUser = sdtuser;
                users.emailUser = emailuser;
                users.matKhau = GetMD5(pwuser);
                users.gioiTinh = gioiTinh;
                users.ngaySinh = myDate;
                users.ngayTao = DateTime.Now;
                users.ngayCapNhat = DateTime.Now;
                users.hoatDongLanCuoi = DateTime.Now;
                users.trangThai = "Chờ xác nhận";

                _context.Add(users);
        
                await _context.SaveChangesAsync();
                
            }
            var dsusers = _context.Users
                   .SingleOrDefault(ipp => (ipp.emailUser == emailuser));
            string intrd;
            Random random = new Random();
            intrd = random.Next(100000, 999999).ToString();

            var itemmxn =
                              new Models.MaXacNhan
                              {
                                  code = intrd,
                                  emails = emailuser,
                                    
                                  
                              };

            HttpContext.Session.Set("mxns", itemmxn);



            var item =
                              new sessionuser
                              {

                                  idUser =dsusers.idUser,
                                  hoUser = houser,
                                  tenUser = tenuser,
                                  sdtUser = sdtuser,
                                  emailUser = emailuser,
                                  gioiTinh = gioiTinh,
                                  ngaySinh = ngaysinh,
                                  diaChi = "",
                                  hinhAVT = "def.jpg",
                                  vaitro = "users",
                              };

            HttpContext.Session.Set("tamp", item);
            ips.idUser = dsusers.idUser;
            _context.Add(ips);

            await _context.SaveChangesAsync();
            //return RedirectToAction("index", "Sendmail");
            ViewBag.mess = "0";
            return View();
        }

      
    }
}
