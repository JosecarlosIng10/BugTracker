using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class AsignarProyecto : System.Web.UI.Page
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
            if (DropDownList1.Text.Equals("1234AA"))
            {
                HttpContext.Current.Response.Write("<script>window.alert('No puedes asignarle proyecto al super usuario');</script>");

            }
            else
            {

                if (funcion.llave(DropDownList1.Text, "USUARIO", "Workerid") != 0)
                {
                    if (funcion.llave(DropDownList2.Text, "PROYECTO", "Projectid") != 0)
                    {
                        funcion.Asignarproyecto(DropDownList1.Text, DropDownList2.Text);
                        HttpContext.Current.Response.Write("<script>window.alert('Se Asigno el usuario');</script>");


                    }
                    else
                    {
                        HttpContext.Current.Response.Write("<script>window.alert('No existe el proyecto');</script>");
                    }

                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('No existe el usuario');</script>");
                }


            }
        }
    }
}