using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        // đây là cách dùng route inline
        //[Route("Home/Index/{id:int}")]
        //interface chung 
        //public IActionResult Index(int id)
        //{
        //    var model = new indexmodel();
        //    model.Message = "hello tao la nam day , ID la " + id;
        //    return View(model);
            
        //}
        public IActionResult Index(string id)
        {
            var model = new indexmodel();
            model.Message = "hello tao la nam day , ID la " + id;
            return View(model);

        }
    }
}