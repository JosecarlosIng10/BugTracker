using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ModificarUsuarios : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if ((Session["usuario"].ToString().Equals("SuperUsuario")) || (Session["usuario"].ToString().Equals("Administrador")))
                {
                    if (Session["usuario"].ToString().Equals("SuperUsuario"))
                    {
                        DropDownList1.Items.Add("Administrador");
                        DropDownList1.Items.Add("Arquitecto");
                        DropDownList1.Items.Add("Developer");
                        DropDownList1.Items.Add("Tester");
                    }
                    else if (Session["usuario"].ToString().Equals("Administrador"))
                    {
                        DropDownList1.Items.Add("Arquitecto");
                        DropDownList1.Items.Add("Developer");
                        DropDownList1.Items.Add("Tester");
                    }


                  

                    for (int a = 1940; a <= 2017; a++)
                    {
                        DropDownList4.Items.Add(a + "");

                    }

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
            if ((TextBox1.Text.Equals("")) || (TextBox3.Text == "") || (TextBox10.Text == "") || (TextBox4.Text == "") || (TextBox5.Text == "") || (TextBox6.Text == "") || (DropDownList1.Text == "") || (DropDownList2.Text == "") || (DropDownList3.Text == "") || (DropDownList4.Text == ""))
            {
                HttpContext.Current.Response.Write("<script>window.alert('Faltan Datos');</script>");


            }

            else
            {

                if (TextBox8.Text != TextBox10.Text)
                {
                    if (funcion.llave(TextBox10.Text, "USUARIO", "Workerid") == 0)
                    {
                        if (TextBox1.Text != TextBox11.Text)
                        {


                            if (funcion.llave(TextBox11.Text, "USUARIO", "Correo") == 0)
                            {
                                string fechan = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                                string hh = funcion.modificarusuario(Convert.ToInt32(TextBox9.Text), TextBox1.Text, TextBox10.Text, DropDownList1.Text, TextBox3.Text, TextBox4.Text, fechan, TextBox5.Text, TextBox6.Text);

                                HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                                TextBox1.Text = "";

                                TextBox3.Text = "";
                                TextBox4.Text = "";
                                TextBox5.Text = "";
                                TextBox6.Text = "";
                                TextBox9.Text = "";
                                TextBox10.Text = "";
                                TextBox11.Text = "";
                                DropDownList1.Text = "";
                                DropDownList2.Text = "";
                                DropDownList3.Text = "";
                                DropDownList4.Text = "";
                            }
                            else
                            {
                                HttpContext.Current.Response.Write("<script>window.alert('El correo ya existe');</script>");
                            }
                        }
                        else
                        {
                            string fechan = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                            string hh = funcion.modificarusuario(Convert.ToInt32(TextBox9.Text), TextBox11.Text,TextBox10.Text, DropDownList1.Text, TextBox3.Text, TextBox4.Text, fechan, TextBox5.Text, TextBox6.Text);

                            HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                            TextBox1.Text = "";

                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";
                            TextBox6.Text = "";
                            TextBox9.Text = "";
                            TextBox8.Text = "";
                            TextBox10.Text = "";
                            TextBox11.Text = "";
                            TextBox8.Enabled = true;
                            DropDownList1.Text = "";
                            DropDownList2.Text = "";
                            DropDownList3.Text = "";
                            DropDownList4.Text = "";

                        }
                    }
                    else
                    {
                        HttpContext.Current.Response.Write("<script>window.alert('Workerid ya existe');</script>");
                    }
                }

                else
                {
                    if (TextBox1.Text != TextBox11.Text)
                    {


                        if (funcion.llave(TextBox11.Text, "USUARIO", "Correo") == 0)
                        {
                            string fechan = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                            string hh = funcion.modificarusuario(Convert.ToInt32(TextBox9.Text), TextBox1.Text, TextBox10.Text, DropDownList1.Text, TextBox3.Text, TextBox4.Text, fechan, TextBox5.Text, TextBox6.Text);

                            HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                            TextBox1.Text = "";

                            TextBox3.Text = "";
                            TextBox4.Text = "";
                            TextBox5.Text = "";
                            TextBox6.Text = "";
                            TextBox9.Text = "";
                            TextBox10.Text = "";
                            TextBox11.Text = "";
                            DropDownList1.Text = "";
                            DropDownList2.Text = "";
                            DropDownList3.Text = "";
                            DropDownList4.Text = "";
                        }
                        else
                        {
                            HttpContext.Current.Response.Write("<script>window.alert('El correo ya existe');</script>");
                        }
                    }
                    else
                    {
                        string fechan = DropDownList2.Text + '/' + DropDownList3.Text + '/' + DropDownList4.Text;
                        string hh = funcion.modificarusuario(Convert.ToInt32(TextBox9.Text), TextBox11.Text, TextBox10.Text, DropDownList1.Text, TextBox3.Text, TextBox4.Text, fechan, TextBox5.Text, TextBox6.Text);

                        HttpContext.Current.Response.Write("<script>window.alert('" + hh + "');</script>");
                        TextBox1.Text = "";

                        TextBox3.Text = "";
                        TextBox4.Text = "";
                        TextBox5.Text = "";
                        TextBox6.Text = "";
                        TextBox9.Text = "";
                        TextBox8.Text = "";
                        TextBox10.Text = "";
                        TextBox11.Text = "";
                        TextBox8.Enabled = true;
                        DropDownList1.Text = "";
                        DropDownList2.Text = "";
                        DropDownList3.Text = "";
                        DropDownList4.Text = "";

                    }

                }
            }
        }
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            String[] datos = funcion.buscardatosusuario(TextBox8.Text);

            if (datos[0] != null)
            {
                TextBox9.Text = datos[0];
                TextBox1.Text = datos[1];
                TextBox11.Text = datos[1];
                TextBox10.Text = datos[2];
                DropDownList1.Text = datos[3];
                TextBox3.Text = datos[4];
                TextBox4.Text = datos[5];
                Char delimiter = '/';
                String[] substrings = datos[6].Split(delimiter);
                DropDownList2.Text = substrings[0];
                DropDownList3.Text = substrings[1];
                DropDownList4.Text = substrings[2];
                TextBox5.Text = datos[7];
                TextBox6.Text = datos[8];
                TextBox8.Enabled = false;
            }
           

        }
    }
}