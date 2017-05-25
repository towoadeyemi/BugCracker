using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugFix.APP_LAYER.AdminSection
{
    public partial class AdminChangeMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string fileName = "";
                    if (FileUpload_HTXT.PostedFile.FileName.Ttrim() != "")
                    
                        { 
                       
                        fileName = System.IO.Path.GetFileName(FIleUpload_HTXT.PostedFile.FileName);
                        string path = Server.MapPath("../ContenetSection/Code") + "/" + fileName;
                        FileUpload_HTXT.PostedFile.SaveAs(path);
                        fileName = "Code/" + fileName;

                        }
                 

                         
            }
            catch(Exception ex)
            {
                BL_Layer.Metasys.MessageBox("something is wrong-error is "+ex.Message);
            }
        }
    }
}