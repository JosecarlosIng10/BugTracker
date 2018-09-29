using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class SituacionCasos : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"].ToString() != "")
                {
                    if (IsPostBack == true)
                    {
                        actualizar();
                    }
                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ((DropDownList2.Text != "") || (DropDownList1.Text != ""))
            {
                funcion.cambiarsituacioncaso(Convert.ToInt32(DropDownList2.Text), DropDownList1.Text);
                DropDownList2.Text = "";

            }
            else
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos ');</script>");

            }
        }
        public void actualizar()
        {
            DropDownList1.Items.Clear();

            if (funcion.Resolvercaso(DropDownList2.Text).Equals("Cerrado"))
            {
                HttpContext.Current.Response.Write("<script>window.alert('El caso ya ha sido cerrado ');</script>");
            }
            else if (funcion.Resolvercaso(DropDownList2.Text).Equals("Resuelto"))
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Listo para pruebas");
                DropDownList1.Items.Add("Implementado");
                DropDownList1.Items.Add("Duplicado");
                DropDownList1.Items.Add("Por diseño");
                DropDownList1.Items.Add("Arreglado");
                DropDownList1.Items.Add("No reproducible");
                DropDownList1.Items.Add("Post puesto");
                DropDownList1.Items.Add("No se arreglara");

            }
            else if ((funcion.Resolvercaso(DropDownList2.Text).Equals("Activo")) || (funcion.Resolvercaso(DropDownList2.Text).Equals("Re activo")))
            {
                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Necesita estimacion de tiempo");
                DropDownList1.Items.Add("Estimacion de tiempo aprobada");
                DropDownList1.Items.Add("En desarrollo");
                DropDownList1.Items.Add("Arreglado");
                DropDownList1.Items.Add("Necesita Informacion");


            }
        }
    

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}