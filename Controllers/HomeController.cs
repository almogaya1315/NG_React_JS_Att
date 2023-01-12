using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NG_React_JS_Att.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {

            //var data = _dalRepo.GetData();
            return View();
        }
    }
}
