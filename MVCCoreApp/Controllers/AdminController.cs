using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCCoreApp.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "hello day laf trang admin";
        }
    }
}