using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class EliminarProyectos : System.Web.UI.Page
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

            String[] datos = new String[8];

           

                if (funcion.llave(TextBox1.Text, "PROYECTO", "Projectid") != 0)

                {
                    datos = funcion.buscardatosproyecto(TextBox1.Text);

                    int cod = Convert.ToInt32(datos[0]);

                    HttpContext.Current.Response.Write("<script>window.alert('" + funcion.eliminarproyecto(cod) + "');</script>");
                    TextBox1.Text = "";
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('Projectid del proyecto no existe');</script>");
                }

            }
            
        
    }
}