using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class CrearCasos : System.Web.UI.Page
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

        protected void Button2_Click(object sender, EventArgs e)
        {
           

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            String[] datos = funcion.buscardatosproyecto(DropDownList8.Text);


            if (datos[0] != null)
            {
                TextBox6.Text = datos[0];

            }
            if ((DropDownList8.Text.Equals("")) || (TextBox5.Text == "") || (TextBox6.Text == "") || (DropDownList1.Text == "") || (DropDownList2.Text == "") || (DropDownList3.Text == "") || (DropDownList4.Text == "") || (DropDownList5.Text == "") || (DropDownList6.Text == "") || (DropDownList7.Text == "") )
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos');</script>");


            }
            
            else
            {
                if (funcion.llave(TextBox7.Text, "CASO", "CodigoCaso") == 0)
                {

                    string fechan = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                    string hh = funcion.insertarcaso(Convert.ToInt32(TextBox7.Text), Convert.ToInt32( TextBox6.Text), DropDownList6.Text, DropDownList7.Text, DropDownList1.Text, fechan, DropDownList5.Text, TextBox5.Text);

                    HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                    
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                   
                    DropDownList1.Text = "";
                    DropDownList2.Text = "";
                    DropDownList3.Text = "";
                    DropDownList4.Text = "";
                DropDownList5.Text = "";
                DropDownList6.Text = "";
                DropDownList7.Text = "";
                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('El caso ya existe');</script>");
                }




            }
        }

        protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (DropDownList6.Text.Equals("Resuelto"))
            {
                DropDownList7.Items.Add("");
                DropDownList7.Items.Add("Listo para pruebas");
                DropDownList7.Items.Add("Implementado");
                DropDownList7.Items.Add("Duplicado");
                DropDownList7.Items.Add("Por diseño");
                DropDownList7.Items.Add("Arreglado");
                DropDownList7.Items.Add("No reproducible");
                DropDownList7.Items.Add("Post puesto");
                DropDownList7.Items.Add("No se arreglara");

            }
            else if ((DropDownList6.Text.Equals("Activo")) || (DropDownList6.Text.Equals("Re activo")))
            {
                DropDownList7.Items.Add("");
                DropDownList7.Items.Add("Necesita estimacion de tiempo");
                DropDownList7.Items.Add("Estimacion de tiempo aprobada");
                DropDownList7.Items.Add("En desarrollo");
                DropDownList7.Items.Add("Arreglado");
                DropDownList7.Items.Add("Necesita Informacion");


            }
            else if (DropDownList6.Text.Equals("Cerrado"))
            {
                DropDownList7.Items.Add("");
                DropDownList7.Items.Add("Cerrado");


            }
        }

        protected void DropDownList8_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void DropDownList8_DataBound(object sender, EventArgs e)
        {
            
        }
    }
}