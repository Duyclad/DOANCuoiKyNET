using DOANCuoiKyNET.Entities;
using DOANCuoiKyNET.MailMessenger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOANCuoiKyNET.Models;
using Microsoft.AspNetCore.Http;
using DOANCuoiKyNET.Session;

namespace DOANCuoiKyNET.Controllers
{
 
    public class SendMailController :Controller
    {
        private readonly IEmailSender _emailsender;
     
        public SendMailController(IEmailSender emailSender)
        {
            _emailsender = emailSender;
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

        [Obsolete]
        public IActionResult Index()
        {

            if (mxn==null)
            {
                return RedirectToAction("index", "Home");
            }
            

            var message = new Message(new string[] {mxn.emails}, "[GONZ Store] Mã xác nhận tài khoản", "Đây là mã xác nhận của bạn: " + mxn.code);
            _emailsender.SendEmail(message);
         
            if (mxn.type == "0")
            {
                ViewBag.type = "0";
                ViewBag.tieude = "Mã xác nhận đã được gửi về email của bạn. Vui lòng nhập mã xác nhận:";
            }
            else if (mxn.type == "1")
            {
                ViewBag.tieude = "Chúng tôi phát hiện bạn đăng nhập từ trình duyệt lạ, do đó chúng tôi đã gửi mã xác nhận về email của bạn. Vui lòng nhập mã xác nhận:";
                ViewBag.type = "1";
            }
            else
            {
                ViewBag.tieude = "Mã xác nhận đã được gửi về email của bạn. Vui lòng nhập mã xác nhận:";
                ViewBag.type = "2";
            }
            return View();
        }

        public Models.MaXacNhan xoass
        {
            get
            {
                var data = HttpContext.Session.Get<Models.MaXacNhan>("mxns");
                if (data != null)
                {
                    data = null;
                }
                return data;

            }

        }

        

    }

}
