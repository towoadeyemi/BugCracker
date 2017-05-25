using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugFix.BL_Layer
{
    public class Metasys
    {
        public static void MessageBox(string YourCode)
        {
            HttpContext.Current.Response.Write("<script>alert('"+YourCode +"')</script>");
        }
    }
}