using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using BLL;
namespace MVCApp.Controllers
{
    public class ProdAdminController : Controller
    {
        //
        // GET: /ProdAdmin/
        public static DataTable dt = new DataTable(); 

        public ActionResult Index()
        {
            
            

            //System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            return View();
        }


        public string abc() {
            dt.Clear();
            ProductAdminBLL bll = new ProductAdminBLL();
            dt = bll.Categories();

            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            Dictionary<string, object> row;

            foreach (DataRow dr in dt.Rows)
            {

                row = new Dictionary<string, object>();

                foreach (DataColumn col in dt.Columns)
                {

                    row.Add(col.ColumnName, dr[col]);

                }

                rows.Add(row);

            }

            return serializer.Serialize(rows);
        }
    }
}
