﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class PostController : Controller
    {
        public IActionResult PostsByID(int id)
        {
            return View();
        }
        public IActionResult PostsByName(string id)
        {
            return View();
        }

    }
}