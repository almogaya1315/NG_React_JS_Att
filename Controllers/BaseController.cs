using Microsoft.AspNetCore.Mvc;
using NG_React_JS_Att.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NG_React_JS_Att.Controllers
{
    public abstract class BaseController : Controller, IController
    {
        protected DalRepository _dalRepo { get; private set; }
        public BaseController()
        {
            _dalRepo = new DalRepository();
        }
    }
}
