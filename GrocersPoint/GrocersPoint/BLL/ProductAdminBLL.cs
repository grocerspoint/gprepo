using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
   public class ProductAdminBLL
    {
        public DataTable Categories()
        {
            //List<Category> cat = new List<Category>();
            DBHelper helper = new DBHelper();
            //Category catg = null;
            DataTable dt = helper.executeSelectQuery(PROCEDURES.GET_ALL_CATEGORIES).Tables[0];
            return dt;
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //   catg = new Category();
            //   catg.Cat_Id = Convert.ToInt32(row[0]);
            //   catg.Cat_Name=row[1].ToString();
            //   cat.Add(catg);
            //}
            //return cat;

            //System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();

            //List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();

            //Dictionary<string, object> row;

            //foreach (DataRow dr in dt.Rows)
            //{

            //    row = new Dictionary<string, object>();

            //    foreach (DataColumn col in dt.Columns)
            //    {

            //        row.Add(col.ColumnName, dr[col]);

            //    }

            //    rows.Add(row);

            //}

            //return serializer.Serialize(rows);

            

        }

        public bool Test()
        {
            SqlParameter[] param = new SqlParameter[1];
            DBHelper helper = new DBHelper();
            param[0] = new SqlParameter(CONSTANT.CAT_ID, "ZCVV");
            bool ds = helper.InsertQuery(PROCEDURES.CAT_INSERT, param);
            return ds;
        }
    }
}
