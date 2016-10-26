using Deadline1.Areas.Admin.Code;
using Deadline1.Areas.Admin.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Deadline1.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        //
        // GET: /Admin/LoginAdmin/
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.Password);
            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                return RedirectToAction("Index", "HomeAdmin");
            }
            else
            {
                ModelState.AddModelError("", "Ten Nhap hoac mat khau khong dung.");
            }
            return View(model);
        }

    }
}
