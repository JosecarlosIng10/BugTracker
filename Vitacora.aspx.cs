using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class Vitacora : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["usuario"].ToString().Equals("SuperUsuario"))
                {
                    for (int a = 1940; a <= 2017; a++)
                    {
                        DropDownList4.Items.Add(a + "");
                        DropDownList7.Items.Add(a + "");

                    }

                    Label1.Text = "Fecha "+ DateTime.Now.ToString("d") + " Hora "+ DateTime.Now.Hour.ToString() +":"+ DateTime.Now.Minute.ToString();
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('No tiene acceso a esta funcion');</script>");

                    Response.Redirect("ProyectosWeb.aspx");
                }

            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           TextBox1.Text = DropDownList2.Text + "/" + DropDownList3.Text + "/" + DropDownList4.Text;
            TextBox2.Text = DropDownList5.Text + "/" + DropDownList6.Text + "/" + DropDownList7.Text;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            GridViewRow row = GridView1.SelectedRow;
            TextBox4.Text = row.Cells[0].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox4.Text = GridView1.SelectedRow.Cells[1].Text;
            String archivo = funcion.llenararchivo(Convert.ToInt32(TextBox4.Text));
            TextBox3.Text = archivo;
            GridView2.Visible = false;
            TextBox3.Visible = true;

        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox4.Text = GridView1.SelectedRow.Cells[1].Text;
            GridView2.DataBind();
            TextBox3.Visible = false;
            GridView2.Visible = true;
        }
    }
}