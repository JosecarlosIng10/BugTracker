using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ConsultarCaso : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"].ToString() != "")
                {

                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String[] datos = funcion.buscardatoscasos(Convert.ToInt32(DropDownList8.Text));

            if (datos[0] != null)
            {

                TextBox6.Text = datos[1];
                DropDownList6.Text = datos[2];
                DropDownList7.Text = datos[3];
                DropDownList1.Text = datos[4];

                Char delimiter = '/';
                String[] substrings1 = datos[5].Split(delimiter);

                DropDownList2.Text = substrings1[0];
                DropDownList3.Text = substrings1[1];
                

                DropDownList5.Text = datos[6];



                TextBox5.Text = datos[7];

               
            }

            String[] datos1 = funcion.buscarnombreproyecto(Convert.ToInt32(TextBox6.Text));
            TextBox1.Text = datos1[0];
        }
    }
}