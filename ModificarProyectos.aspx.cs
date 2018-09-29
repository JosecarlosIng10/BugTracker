using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ModificarProyectos : System.Web.UI.Page
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
            if ((TextBox1.Text.Equals("")) || (TextBox5.Text == "") || (DropDownList8.Text == "") || (TextBox10.Text == "")  || (DropDownList2.Text == "") || (DropDownList3.Text == "") || (DropDownList4.Text == "") || (DropDownList5.Text == "") || (DropDownList6.Text == "") || (DropDownList7.Text == ""))
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos');</script>");


            }

            else
            {

                if (TextBox8.Text != TextBox10.Text)
                {
                    if (funcion.llave(TextBox10.Text, "PROYECTO", "Projectid") == 0)
                    {
                        string fechai = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                        string fechaf = DropDownList5.Text + '/' + DropDownList6.Text + '/' + DropDownList7.Text;
                        string hh = funcion.modificarproyecto(Convert.ToInt32(TextBox9.Text),DropDownList8.Text, TextBox1.Text, TextBox10.Text, fechai, fechaf, Convert.ToInt32(TextBox5.Text));

                        HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                        TextBox1.Text = "";

                        TextBox5.Text = "";
                        
                        TextBox10.Text = "";
                        DropDownList8.Text = "";
                        DropDownList2.Text = "";
                        DropDownList3.Text = "";
                        DropDownList4.Text = "";
                        DropDownList5.Text = "";
                        DropDownList6.Text = "";
                        DropDownList7.Text = "";
                        TextBox9.Text = "";
                        TextBox8.Enabled = true;
                        TextBox8.Text = "";
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("<script>window.alert('ProjectId del proyecto ya existe');</script>");
                    }
                }

                else
                {
                    string fechai = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                    string fechaf = DropDownList5.Text + '/' + DropDownList6.Text + '/' + DropDownList7.Text;
                    string hh = funcion.modificarproyecto(Convert.ToInt32(TextBox9.Text),DropDownList8.Text, TextBox1.Text, TextBox10.Text, fechai, fechaf, Convert.ToInt32(TextBox5.Text));

                    HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                    TextBox1.Text = "";

                    TextBox5.Text = "";
                   
                    TextBox10.Text = "";
                   

                    DropDownList2.Text = "";
                    DropDownList3.Text = "";
                    DropDownList4.Text = "";
                    DropDownList5.Text = "";
                    DropDownList6.Text = "";
                    DropDownList7.Text = "";
                    TextBox9.Text = "";
                    TextBox8.Enabled = true;
                    TextBox8.Text = "";

                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String[] datos = funcion.buscardatosproyecto(TextBox8.Text);

            if (datos[0] != null)
            {
                TextBox9.Text = datos[0];
                DropDownList8.Text = datos[1];
                TextBox1.Text = datos[2];
                TextBox10.Text = datos[3];

                Char delimiter = '/';
                String[] substrings1 = datos[4].Split(delimiter);

                DropDownList2.Text = substrings1[0];
                DropDownList3.Text = substrings1[1];
                DropDownList4.Text = substrings1[2];

                String[] substrings2 = datos[5].Split(delimiter);

                DropDownList5.Text = substrings2[0];
                DropDownList6.Text = substrings2[1];
                DropDownList7.Text = substrings2[2];

                TextBox5.Text = datos[6];
                
                TextBox8.Enabled = false;
            }


        
    }
    }
}