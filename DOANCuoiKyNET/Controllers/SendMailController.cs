using DOANCuoiKyNET.Entities;
using DOANCuoiKyNET.MailMessenger;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Controllers
{
 
    public class SendMailController :Controller
    {
        private readonly IEmailSender _emailsender;
     
        public SendMailController(IEmailSender emailSender)
        {
            _emailsender = emailSender;
        }

        


        [HttpPost]
        [Obsolete]
        public IActionResult Index()
        {

            var message = new Message(new string[] { "duyclad@gmail.com" }, "Test email", "This is the content from our email.");
            _emailsender.SendEmail(message);

            return View();
        }
       

       
    }

}
