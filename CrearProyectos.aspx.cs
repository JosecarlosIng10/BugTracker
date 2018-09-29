using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class CrearProyectos : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if ((Session["usuario"].ToString().Equals("SuperUsuario")) || (Session["usuario"].ToString().Equals("Administrador")))
                {
                    for (int a = 2000; a <= 2017; a++)
                    {
                        DropDownList4.Items.Add(a + "");

                    }
                    for (int a = 2000; a <= 2025; a++)
                    {
                        DropDownList7.Items.Add(a + "");

                    }
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('No tiene acceso a esta funcion');</script>");

                    Response.Redirect("PrincipalWeb.aspx");
                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }

        



        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if ((TextBox1.Text.Equals(""))  || (TextBox5.Text == "") || (TextBox7.Text == "") || (DropDownList8.Text == "")  || (DropDownList2.Text == "") || (DropDownList3.Text == "") || (DropDownList4.Text == "") || (DropDownList5.Text == "") || (DropDownList6.Text == "") || (DropDownList7.Text == ""))
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos');</script>");


            }
            

            else
            {
                if (funcion.llave(TextBox7.Text, "PROYECTO", "Projectid") == 0)
                {
                    string fechai = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                    string fechaf = DropDownList5.Text + '/' + DropDownList6.Text + '/' + DropDownList7.Text;
                    string hh = funcion.insertarproyecto(DropDownList8.Text, TextBox1.Text,TextBox7.Text, fechai,fechaf, Convert.ToInt32(TextBox5.Text));

                    HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                    TextBox1.Text = "";
                    
                    TextBox5.Text = "";
                   
                    TextBox7.Text = "";

                    
                    DropDownList2.Text = "";
                    DropDownList3.Text = "";
                    DropDownList4.Text = "";
                    DropDownList5.Text = "";
                    DropDownList6.Text = "";
                    DropDownList7.Text = "";
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('Projectid ya existe');</script>");
                }



            }
        }
    }
}