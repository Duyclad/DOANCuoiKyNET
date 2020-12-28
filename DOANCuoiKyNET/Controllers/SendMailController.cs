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

        [HttpGet]
        [Obsolete]
        public IActionResult Index()
        {

            /*if (mxn==null)
            {
                return RedirectToAction("index", "Home");
            }*/
            

            var message = new Message(new string[] {"coleanhduy@gmail.com"}, "ok", "test");
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

        [HttpPost]
        public IActionResult XacNhan(string codex)
        {

            if (mxn.code == codex)
            {
                Models.MaXacNhan session = xoass;
                HttpContext.Session.Set("mxns",session);

                return RedirectToAction("index", "Home");
            }
            else
            {
                ViewBag.mess = "0";
                 return View();
            }

           
        }


    }

}
