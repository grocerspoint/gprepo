using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace MVCApp.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(BLL.User_Details user)
        {
            if (ModelState.IsValid)
            {
                LoginBLL bll = new LoginBLL();
               string str= bll.LoginCheck(user);
               if (str == "Admin")
               {

                  return RedirectToAction("Admin", "Admin");
               }
               else if (str == "Prod_Admin")
               {

                   return RedirectToAction("ProductAdmin", "Admin");
               }
               else if (str == "User")
               {

                   return RedirectToAction("User", "Admin");
               }
               else
               {
                   ModelState.AddModelError("", "Login data is incorrect!");
                   return RedirectToAction("Index");
               }
            }

            return View();
        }

        public ActionResult ProductAdmin()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }
        public ActionResult User()
        {
            return View();
        }
    }
}
