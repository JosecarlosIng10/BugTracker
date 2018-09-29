using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ReporteFiltros : System.Web.UI.Page
    {
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
                    Label1.Text = "Fecha " + DateTime.Now.ToString("d") + " Hora " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();


                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }

           
        }
        public void actualizar()
        {
            //GridView1.DataSource = "";
            GridView1.DataBind();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == true)
            {
                RadioButton2.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;

                DropDownList1.Items.Clear();

                DropDownList1.Items.Add("Activo");
                DropDownList1.Items.Add("Resuelto");
                DropDownList1.Items.Add("Cerrado");
                DropDownList1.Items.Add("Re activado");

            }

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (RadioButton2.Checked == true)
            {
                RadioButton1.Checked = false;
                RadioButton3.Checked = false;
                RadioButton4.Checked = false;

                DropDownList1.Items.Clear();

                DropDownList1.Items.Add("Bug");
                DropDownList1.Items.Add("Mejora");
                DropDownList1.Items.Add("Investigacion");
                DropDownList1.Items.Add("Actividad");

            }
        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (RadioButton3.Checked == true)
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = false;
                RadioButton4.Checked = false;

                DropDownList1.Items.Clear();

                DropDownList1.Items.Add("");
                DropDownList1.Items.Add("Listo para pruebas");
                DropDownList1.Items.Add("Implementado");
                DropDownList1.Items.Add("Duplicado");
                DropDownList1.Items.Add("Por diseño");
                DropDownList1.Items.Add("Arreglado");
                DropDownList1.Items.Add("No reproducible");
                DropDownList1.Items.Add("Post puesto");
                DropDownList1.Items.Add("No se arreglara");
                DropDownList1.Items.Add("Necesita estimacion de tiempo");
                DropDownList1.Items.Add("Estimacion de tiempo aprobada");
                DropDownList1.Items.Add("En desarrollo");
              
                DropDownList1.Items.Add("Necesita Informacion");
                DropDownList1.Items.Add("Cerrado");

            }
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == true)
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = false;
                RadioButton3.Checked = false;
                DropDownList1.Items.Clear();
                DropDownList1.Items.Add("Todos");

            }
            }
    }
}