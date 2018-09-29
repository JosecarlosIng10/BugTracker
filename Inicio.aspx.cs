using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class Inicio : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {
           try
            {
                if (Session["usuario"].ToString()!= "")
                {
                    Response.Redirect("Principalweb.aspx");
                }
            }

            catch
            {
               
               
            }
            
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (funcion.inciarsesion(TextBox1.Text, TextBox2.Text) != 0)
            {
                String tipo = funcion.tipo(TextBox1.Text);
              

                Session["usuario"] = tipo;
                Response.Redirect("PrincipalWeb.aspx");

               


            }
            else
            {
                HttpContext.Current.Response.Write("<script>window.alert('El usuario o la contraseña son incorrectos');</script>");

            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Recuperar.aspx");
        }
    }
}