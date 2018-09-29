using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class Recuperar : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (funcion.llave(TextBox1.Text, "USUARIO", "CORREO") == 0)
            {
                HttpContext.Current.Response.Write("<script>window.alert('El correo no existe');</script>");


            }
            else if (TextBox2.Text != "juan1234")
            {
                HttpContext.Current.Response.Write("<script>window.alert('La contraseña es incorrecta');</script>");


            }
            else
            {
                TextBox3.Text = funcion.recuperar(TextBox1.Text, "juan1234");
            }
        }
    }
}