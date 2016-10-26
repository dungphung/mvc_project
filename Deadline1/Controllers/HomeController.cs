using Deadline1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Deadline1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            // Dùng đối tượng ViewBag
            ViewBag.WelcomeString = "Chao mung ban den voi ViewBag";
            
            // Tạo 1 model
            var message = new MessageModel();
            message.Welcome = "Chao mung den voi models";

            return View(message);
        }

    }
}
