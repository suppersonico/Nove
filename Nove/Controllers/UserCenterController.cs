﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nove.Controllers
{
    public class UserCenterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}