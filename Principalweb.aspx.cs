using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class Principalweb : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["usuario"].ToString().Equals(""))
                {
                    Response.Redirect("Inicio.aspx");
                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}