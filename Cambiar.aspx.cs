using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class Cambiar : System.Web.UI.Page
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
            String[] datos = new String[8];
           

            if (funcion.inciarsesion(TextBox1.Text, TextBox2.Text) != 0)
            {
                datos = funcion.buscardatosusuario(TextBox1.Text);

                int cod = Convert.ToInt32(datos[0]);
                if (TextBox3.Text.Equals(TextBox4.Text))
                {
                    HttpContext.Current.Response.Write("<script>window.alert('"+ funcion.cambiar(cod, TextBox3.Text) +"');</script>");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('La nueva contraseña no coincide');</script>");


                }


            }
            else
            {
                HttpContext.Current.Response.Write("<script>window.alert('El usuario o la contraseña son incorrectos');</script>");


            }

        }
    }
}