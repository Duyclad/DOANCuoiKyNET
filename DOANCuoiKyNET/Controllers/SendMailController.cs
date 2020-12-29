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
