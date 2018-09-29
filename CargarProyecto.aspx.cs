using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class CargarProyecto : System.Web.UI.Page
    {
        funcion funcion = new funcion();
        
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["usuario"].ToString().Equals("SuperUsuario"))
                {

                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('No tiene acceso a esta funcion');</script>");

                    Response.Redirect("ProyectosWeb.aspx");
                }

            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        public string filename = "";

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (FileUploadControl.HasFile)
            {
                try
                {
                    filename = Path.GetFileName(FileUploadControl.FileName);
                    FileUploadControl.SaveAs(Server.MapPath("~/") + filename);

                    // string texto = File.ReadAllText(Server.MapPath("~/") + filename);
                    string[] lineas = File.ReadAllLines(Server.MapPath("~/") + filename);
                    
                    int i = 0;


                    while (lineas.Length > i)
                    {
                        TextBox1.Text = TextBox1.Text + lineas[i] + "\r\n";
                        //TextBox1.Text = texto + Environment.NewLine;
                        i++;
                    }


                    //TextBox1.Text = texto + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    TextBox1.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
                }
            }

        }

        public void cargar()
        {
            String projectid = "";
            String workerid = "";
            String nombreproyecto = "";
            String fechainicio = "";
            String fechafin = "";
            String costo = "";
            String descripcion = "";
            String pro = "";
            int cargados = 0;
            int nocargados = 0;
            int total = 0;

            bool cargar = true;
            

            string[] linea = TextBox1.Text.Split('\n');

            for (int i = 0; i < linea.Length; i++)
            {

                string[] datos = linea[i].Split(',');

                try
                {
                    projectid = datos[0];
                    workerid = datos[1];
                    nombreproyecto = datos[2];
                    fechainicio = datos[3];
                    fechafin = datos[4];
                    costo = datos[5];

                    if (funcion.llave(projectid, "PROYECTO", "Projectid") != 0)
                    {
                        descripcion = descripcion + "\n" + "Projectid Ya Existe";
                        pro = pro + "si/";
                        cargar = false;
                    }
                    else
                    {
                        pro = pro + "no/";
                    }
                    if (funcion.verificarencargado(workerid) == false)
                    {
                        descripcion = descripcion + "\n" + "Encargado no existe";

                        cargar = false;
                    }
                    if (verificarfecha(fechainicio) == false)
                    {
                        descripcion = descripcion + "\n" + "Fecha de Inicio no es correcta";

                        cargar = false;
                    }
                    if (verificarfecha(fechafin) == false)
                    {
                        descripcion = descripcion + "\n" + "Fecha de fin no es correcta";

                        cargar = false;
                    }
                    if (Convert.ToDouble(costo) <= 0)
                    {
                        descripcion = descripcion + "\n" + "Costo incorrecto";

                        cargar = false;
                    }


                    if (cargar == true)
                    {
                        funcion.insertarproyecto(workerid, nombreproyecto, projectid, fechainicio, fechafin, Convert.ToDouble(costo));
                        cargados++;
                    }
                    else
                    {
                        nocargados++;
                    }



                }
                 
            catch
            {
                    nocargados++;      
            }
        }
           
       

            total = cargados + nocargados;
                DateTime fechacarga = DateTime.Now;
                string fecha = fechacarga.ToString("d");

                String hora = fechacarga.Hour.ToString() + ":" + fechacarga.Minute.ToString() + ":" + fechacarga.Second.ToString();


                funcion.carga(fecha, total, cargados, nocargados, hora);
                detalle(fecha, hora,pro);

           




        }

        public void detalle(String fecha, String hora,String pro)
        {

            String[] nocarga = funcion.buscarcarga(fecha, hora);
            String[] proj = pro.Split('/');
            int carga = Convert.ToInt32(nocarga[0]);

            String projectid = "";
            String workerid = "";
            String nombreproyecto = "";
            String fechainicio = "";
            String fechafin = "";
            String costo = "";
            String descripcion = "";

           
           

            bool cargar = true;
            

            String estado = "";

            string[] linea = TextBox1.Text.Split('\n');

            for (int i = 0; i < linea.Length; i++)
            {

                string[] datos = linea[i].Split(',');

                try
                {

                    projectid = datos[0];
                    workerid = datos[1];
                    nombreproyecto = datos[2];
                    fechainicio = datos[3];
                    fechafin = datos[4];
                    costo = datos[5];

                    if (proj[i].Equals("si"))
                    {
                        descripcion = descripcion + "\n" + "Projectid Ya Existe";

                        cargar = false;

                    }

                   
                    if (funcion.verificarencargado(workerid) == false)
                    {
                        descripcion = descripcion + "\n" + "Encargado no existe";

                        cargar = false;
                    }
                    if (verificarfecha(fechainicio) == false)
                    {
                        descripcion = descripcion + "\n" + "Fecha de Inicio no es correcta";

                        cargar = false;
                    }
                    if (verificarfecha(fechafin) == false)
                    {
                        descripcion = descripcion + "\n" + "Fecha de fin no es correcta";

                        cargar = false;
                    }
                    if (Convert.ToDouble(costo) <= 0)
                    {
                        descripcion = descripcion + "\n" + "Costo incorrecto";

                        cargar = false;
                    }


                    if (cargar == true)
                    {
                        estado = "Cargado";

                        funcion.detallecarga(carga, linea[i], estado, descripcion);
                        descripcion = "";
                    }
                    else
                    {
                        estado = "No Cargado";
                        funcion.detallecarga(carga, linea[i], estado, descripcion);
                        descripcion = "";
                    }

                }
                catch
                {
                    estado = "No Cargado";
                    descripcion = "Mal formato";
                    funcion.detallecarga(carga, linea[i], estado, descripcion);
                    descripcion = "";
                }

            }

            TextBox1.Text = "";
            HttpContext.Current.Response.Write("<script>window.alert('Carga Completa ');</script>");
           

        }

        public bool verificarfecha(string fecha)
        {

            bool correcto = true;
            string[] y = fecha.Split('/');

            if ( ((Convert.ToInt32( y[0]) > 31)) || ((Convert.ToInt32(y[1]) > 12)) || ((Convert.ToInt32(y[2]) > 2050)))
            {
                correcto = false;

            }

            return correcto;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}