using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
namespace MVCApp.Controllers
{
    public class ProdAdminController : Controller
    {
        //
        // GET: /ProdAdmin/

        public ActionResult Index()
        {
            ProductAdminBLL bll = new ProductAdminBLL();
            List<Category> cat = bll.Categories();
            return View(cat);
        }

    }
}
