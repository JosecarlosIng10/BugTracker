using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class CrearUsuarios : System.Web.UI.Page
    {
        funcion funcion = new funcion();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ((Session["usuario"].ToString().Equals("SuperUsuario")) || (Session["usuario"].ToString().Equals("Administrador")))
                {

                    if (Session["usuario"].ToString().Equals("SuperUsuario"))
                    {
                        DropDownList1.Items.Add("Administrador");
                        DropDownList1.Items.Add("Arquitecto");
                        DropDownList1.Items.Add("Developer");
                        DropDownList1.Items.Add("Tester");
                    }
                    else if (Session["usuario"].ToString().Equals("Administrador"))
                    {
                        DropDownList1.Items.Add("Arquitecto");
                        DropDownList1.Items.Add("Developer");
                        DropDownList1.Items.Add("Tester");
                    }


                  



                    for (int a = 1940; a <= 2017; a++)
                    {
                        DropDownList4.Items.Add(a + "");

                    }
                }
                else
                {
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
            if((TextBox1.Text.Equals("")) || (TextBox2.Text == "") || (TextBox8.Text == "") || (TextBox7.Text == "") || (TextBox3.Text == "") || (TextBox4.Text == "") || (TextBox5.Text == "") || (TextBox6.Text == "") || (DropDownList1.Text=="") || (DropDownList2.Text == "") || (DropDownList3.Text == "") || (DropDownList4.Text == ""))
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos');</script>");
                
                 
            }
            else if (TextBox2.Text != TextBox7.Text)
            {
                HttpContext.Current.Response.Write("<script>window.alert('Las contraseñas no coinciden');</script>");

            }

            else
            {
                if (funcion.llave(TextBox8.Text, "USUARIO", "Workerid") == 0)
                {
                    if (funcion.llave(TextBox1.Text, "USUARIO", "Correo") == 0)
                    {

                        string fechan = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                        string hh = funcion.insertarusuario(TextBox8.Text, TextBox1.Text, TextBox2.Text, DropDownList1.Text, TextBox3.Text, TextBox4.Text, fechan, TextBox5.Text, TextBox6.Text);

                        HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox7.Text = "";
                        TextBox8.Text = "";
                        DropDownList1.Text = "";
                        DropDownList2.Text = "";
                        DropDownList3.Text = "";
                        DropDownList4.Text = "";
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("<script>window.alert('Correo ya existe');</script>");
                    }
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('WorkerId ya existe');</script>");
                }

               

            }
        }

       
    }
}