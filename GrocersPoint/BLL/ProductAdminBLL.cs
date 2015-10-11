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
        public List<Category> Categories()
        {
            List<Category> cat = new List<Category>();
            DBHelper helper = new DBHelper();
            Category catg = null;
            DataSet ds = helper.executeSelectQuery(PROCEDURES.GET_ALL_CATEGORIES);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
               catg = new Category();
               catg.Cat_Id = Convert.ToInt32(row[0]);
               catg.Cat_Name=row[1].ToString();
               cat.Add(catg);
            }
            return cat;
            

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
