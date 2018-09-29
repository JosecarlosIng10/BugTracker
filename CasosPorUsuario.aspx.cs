using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class CasosPorUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"].ToString() != "")
                {
                    Label1.Text = "Fecha " + DateTime.Now.ToString("d") + " Hora " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

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
            
            GridView1.DataBind();
        }
    }
}