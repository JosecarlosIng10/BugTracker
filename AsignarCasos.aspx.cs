using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class AsignarCasos : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
             if (funcion.llave(DropDownList1.Text, "USUARIO", "Workerid") != 0)
            {
                if (funcion.llave(DropDownList2.Text, "CASO", "CodigoCaso") != 0)
                {
                    funcion.Asignarcaso(DropDownList1.Text, DropDownList2.Text);
                    HttpContext.Current.Response.Write("<script>window.alert('Se asigno el caso');</script>");
                    
             

                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('No existe el caso');</script>");
                }

            }
            else
            {
                HttpContext.Current.Response.Write("<script>window.alert('No existe el usuario');</script>");
            }

             
        }
        public void actualizar()
        {
            DropDownList1.Items.Clear();
            DropDownList1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
    }
