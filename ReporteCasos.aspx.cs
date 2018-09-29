using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ReporteCasos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"].ToString() != "")
                {
                    if (IsPostBack == true)
                    {
                        actualizar();
                    }
                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }
            
        }
        public void actualizar()
        {
            //GridView1.DataSource = "";
            GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}