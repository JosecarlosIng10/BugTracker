using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class EliminarUsuarios : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ((Session["usuario"].ToString().Equals("SuperUsuario")) || (Session["usuario"].ToString().Equals("Administrador")))
                {

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
            String[] datos = new String[9];

            if (TextBox1.Text != "1234AA")
            {

                if (funcion.llave(TextBox1.Text, "USUARIO", "Workerid") != 0)

                {
                    datos = funcion.buscardatosusuario(TextBox1.Text);

                    int cod = Convert.ToInt32(datos[0]);

                    HttpContext.Current.Response.Write("<script>window.alert('" + funcion.eliminarusuario(cod) + "');</script>");
                    TextBox1.Text = "";
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('Workerid no existe');</script>");
                }

            }
            else
            {
                HttpContext.Current.Response.Write("<script>window.alert('No puede eliminar al super usuario');</script>");
            }
                    
        }
    }
}