using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ResolverCasos : System.Web.UI.Page
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

                if (IsPostBack == true)
                {
                    actualizar();
                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }


        }
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((DropDownList2.Text != "") || (DropDownList1.Text != ""))
            {
                funcion.cambiarestadocaso(Convert.ToInt32(DropDownList2.Text), DropDownList1.Text);
                DropDownList2.Text = "";

            }
            else
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos ');</script>");

            }



        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           
        }

        public void actualizar()
        {
            if (funcion.Resolvercaso(DropDownList2.Text).Equals("Cerrado"))
            {
                HttpContext.Current.Response.Write("<script>window.alert('El caso ya ha sido cerrado ');</script>");
            }
            else if (funcion.Resolvercaso(DropDownList2.Text).Equals("Activo"))
            {
                DropDownList1.Items.Add("Activo");
                DropDownList1.Items.Add("Resuelto");
                DropDownList1.Items.Add("Cerrado");

            }
            else if (funcion.Resolvercaso(DropDownList2.Text).Equals("Resuelto"))
            {
                DropDownList1.Items.Add("Resuelto");
                DropDownList1.Items.Add("Re activo");
                DropDownList1.Items.Add("Cerrado");

            }
            else if (funcion.Resolvercaso(DropDownList2.Text).Equals("Re activo"))
            {
                DropDownList1.Items.Add("Re activo");
                DropDownList1.Items.Add("Resuelto");
                DropDownList1.Items.Add("Cerrado");

            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}