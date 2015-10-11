using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public struct PROCEDURES
    {
        public static string CAT_INSERT = "Admin_InsertCategory";
        public static string GET_ALL_CATEGORIES = "GetAllCategories";
        public static string LOGIN_CHECK = "login_check_SP";
    }
    public struct CONSTANT
    {

        public static string CAT_ID = "@category_name";
        public static string UID = "@uid";
        public static string PASSWORD = "@pass";


    }
}
