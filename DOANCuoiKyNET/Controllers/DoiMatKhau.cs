using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DOANCuoiKyNET.Controllers
{
    public class DoiMatKhau : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
