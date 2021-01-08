using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Areas.Admin.Controllers
{
    public class DonHangsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
