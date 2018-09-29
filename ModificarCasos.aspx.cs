using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ModificarCasos : System.Web.UI.Page
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
            String[] datos = funcion.buscardatoscasos(Convert.ToInt32( TextBox7.Text));

            if (datos[0] != null)
            {
                
                TextBox6.Text = datos[1];
                DropDownList6.Text = datos[2];


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

                DropDownList7.Text = datos[3];
                DropDownList1.Text = datos[4];

                Char delimiter = '/';
                String[] substrings1 = datos[5].Split(delimiter);

                DropDownList2.Text = substrings1[0];
                DropDownList3.Text = substrings1[1];
                DropDownList4.Text = substrings1[2];

                DropDownList5.Text = datos[6];



                TextBox5.Text = datos[7];
               
                TextBox7.Enabled = false;
                TextBox1.Enabled = false;

                
                
            }

            String[] datos1 = funcion.buscarnombreproyecto(Convert.ToInt32(TextBox6.Text));
            TextBox1.Text = datos1[0];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if ( (TextBox5.Text == "") || (TextBox7.Text == "") || (TextBox6.Text == "") || (DropDownList1.Text == "") || (DropDownList2.Text == "") || (DropDownList3.Text == "") || (DropDownList4.Text == "") || (DropDownList5.Text == "") || (DropDownList6.Text == "") || (DropDownList7.Text == ""))
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos');</script>");


            }

            else
            {
                


                string fechan = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;

                string hh = funcion.modificarcasos(Convert.ToInt32(TextBox7.Text), DropDownList6.Text, DropDownList7.Text, DropDownList1.Text, fechan, DropDownList5.Text, TextBox5.Text);
               
                HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                    TextBox1.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                TextBox7.Text = "";

                    DropDownList1.Text = "";
                    DropDownList2.Text = "";
                    DropDownList3.Text = "";
                    DropDownList4.Text = "";
                    DropDownList5.Text = "";
                    DropDownList6.Text = "";
                    DropDownList7.Text = "";

               


                TextBox1.Enabled = true;
                TextBox7.Enabled = true;


            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           

        }
    }
}