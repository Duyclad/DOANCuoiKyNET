using DOANCuoiKyNET.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeAdminController : Controller

    {
        


        public IActionResult Index()
        {
            return View();
        }
        

       
    }
}
