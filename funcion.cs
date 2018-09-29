using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BugTracker
{
    public class funcion
    {
        conexion conexion = new conexion();
        public SqlCommand cmd;
        public SqlDataReader dr;
        public String insertarusuario(String workerid,String correo, String contraseña, String tipo,String nombres,String apellidos,String fecha,String direccion,String telefono)
        {

            String salida = "Si se guardo el Usuario";


            try
            {
                
                    cmd = new SqlCommand("Insert into USUARIO(Correo,Workerid,Contraseña,Tipo,Nombres,Apellidos,FechaDeNacimiento,Direccion,Telefono) values ('" + correo + "', '" + workerid + "','" + contraseña+ "', '" + tipo + "', '" + nombres + "', '" + apellidos + "', '" + fecha + "', '" + direccion + "', '" + telefono + "')", conexion.conec);
                   cmd.ExecuteNonQuery();

                

               
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;



        }

        public int llave(String llave,String tabla,String nombrecampo)
        {
            int cont = 0;




            try
            {
                cmd = new SqlCommand("Select * from "+tabla+" where "+nombrecampo+" ='" + llave + "' ", conexion.conec);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cont++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }

            return cont;



        }
        public String modificarusuario(int cod,String correo, String workerid,String tipo, String nombres, String apellidos, String fecha, String direccion, String telefono)
        {
            string salida = "Se guardaron los cambios";

            try
            {
                cmd = new SqlCommand("UPDATE USUARIO SET CORREO= '" + correo + "',Workerid= '" + workerid + "', Tipo='" + tipo + "', Nombres='" + nombres + "',Apellidos='" + apellidos + "',FechaDeNacimiento='" + fecha + "',Direccion='" + direccion + "' , Telefono='" + telefono + "' WHERE CodigoUsuario="+cod+";", conexion.conec);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;


            

        }

        public String[] buscardatosusuario(String workerid)
        {
            String[] datos = new String[9];
            cmd = new SqlCommand("SELECT CodigoUsuario, Correo,Workerid,  Tipo,Nombres,Apellidos,FechaDeNacimiento,Direccion,Telefono FROM USUARIO WHERE Workerid = '" + workerid + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    datos[0] = dr["CodigoUsuario"].ToString();
                    datos[1] = dr["Correo"].ToString();
                    datos[2] = dr["Workerid"].ToString();
                    datos[3] = dr["Tipo"].ToString();
                    datos[4] = dr["Nombres"].ToString();
                    datos[5] = dr["Apellidos"].ToString();
                    datos[6] = dr["FechaDeNacimiento"].ToString();
                    datos[7] = dr["Direccion"].ToString();
                    datos[8] = dr["Telefono"].ToString();


                }
                
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('El correo no esta registrado');</script>");

                }
                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }
            return datos;

        }


        public String insertarproyecto(String workerid,String Nombre,String projectid, String fechai, String fechaf, double monto)
        {


            


            String salida = "Si se guardo el Proyecto";


            try
            {

                cmd = new SqlCommand("Insert into PROYECTO(Workedid,Nombre,Projectid,Fecha_Inicio,Fecha_Fin,MontoPresupuestado) values ('" + workerid + "','" + Nombre + "','" + projectid + "', '" + fechai + "', '" + fechaf + "', '"+monto+ "')", conexion.conec);
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;



        }


        public String[] buscardatosproyecto(String projectid)
        {
            String[] datos = new String[7];
            cmd = new SqlCommand("SELECT CodigoProyecto,Workedid, Nombre, Projectid, Fecha_Inicio,Fecha_Fin,MontoPresupuestado FROM PROYECTO WHERE Projectid = '" + projectid + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    datos[0] = dr["CodigoProyecto"].ToString();
                    datos[1] = dr["Workedid"].ToString();
                    datos[2] = dr["Nombre"].ToString();
                    datos[3] = dr["Projectid"].ToString();
                    datos[4] = dr["Fecha_Inicio"].ToString();
                    datos[5] = dr["Fecha_Fin"].ToString();
                    datos[6] = dr["MontoPresupuestado"].ToString();
                   
                   


                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('Projectid del proyecto no esta registrado');</script>");

                }
                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }
            return datos;

        }

        public String modificarproyecto(int cod,String workedid, String Nombre,String projectid, String fechai, String fechaf, int monto)
        {
            string salida = "Se guardaron los cambios";

            try
            {
                cmd = new SqlCommand("UPDATE PROYECTO SET  Workedid= '" + workedid + "', Nombre= '" + Nombre + "', Projectid= '" + projectid + "', Fecha_Inicio='" + fechai + "', Fecha_Fin='" + fechaf + "',MontoPresupuestado='" + monto + "' WHERE CodigoProyecto=" + cod + ";", conexion.conec);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;




        }


        public String insertarcaso(int cod,int codpro, String estado, String situacion, String prioridad, String fechae, String categoria, String descripcion)
        {

            String salida = "Si se guardo el caso";


            try
            {

                cmd = new SqlCommand("Insert into CASO(CodigoCaso,CodigoProyecto,Estado,Situacion,Prioridad,FechaEntrega,Categoria,Descripcion) values ('"+ cod +"' , '" + codpro + "', '" + estado + "', '" + situacion + "', '" + prioridad + "', '" + fechae + "', '" + categoria + "', '" + descripcion + "')", conexion.conec);
                cmd.ExecuteNonQuery();
                insertarcasomodificacion(cod, estado, situacion, prioridad, fechae, categoria, descripcion);




            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;



        }

        public String[] buscardatoscasos(int cod)
        {
            String[] datos = new String[8];
            cmd = new SqlCommand("SELECT CodigoCaso,CodigoProyecto,Estado,Situacion,Prioridad,FechaEntrega,Categoria,Descripcion FROM CASO WHERE CodigoCaso = '" + cod + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    datos[0] = dr["CodigoCaso"].ToString();
                    datos[1] = dr["CodigoProyecto"].ToString();
                    datos[2] = dr["Estado"].ToString();
                    datos[3] = dr["Situacion"].ToString();
                    datos[4] = dr["Prioridad"].ToString();
                    datos[5] = dr["FechaEntrega"].ToString();
                    datos[6] = dr["Categoria"].ToString();
                    datos[7] = dr["Descripcion"].ToString();



                }
               

                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('El codigo del caso no esta registrado');</script>");

                }
                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }
            return datos;

        }

        public String llenararchivo(int cod)
        {
            String[] datos = new String[1];
            String linea = "";
            cmd = new SqlCommand("SELECT * FROM DETALLE_CARGA WHERE NoCarga = '" + cod + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    datos[0] = dr["LineaCarga"].ToString();

                    linea = linea + "\n" + datos[0];
                    



                }

              

                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }
            return linea;

        }

        public String modificarcasos( int cod,String Estado, String Situacion, String Prioridad,  String fechan,String categoria, String descripcion)
        {
            string salida = "Se guardaron los cambios";

            try
            {
                cmd = new SqlCommand("UPDATE CASO SET Estado= '" + Estado + "', Situacion='" + Situacion + "', Prioridad='" + Prioridad + "',FechaEntrega ='" + fechan + "',Categoria='" + categoria + "' ,Descripcion='" + descripcion + "' WHERE CodigoCaso=" + cod + ";", conexion.conec);
                cmd.ExecuteNonQuery();
                insertarcasomodificacion(cod, Estado, Situacion, Prioridad, fechan, categoria, descripcion);
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;




        }

        public String[] buscarnombreproyecto(int cod)
        {
            String[] datos = new String[1];
            cmd = new SqlCommand("SELECT  Nombre FROM PROYECTO WHERE CodigoProyecto = '" + cod + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    datos[0] = dr["Nombre"].ToString();
                   



                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('El Codigo del proyecto no esta registrado');</script>");

                }
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }
            return datos;

        }

        public String[] buscarcarga(String fecha, String hora)
        {
            String[] datos = new String[1];
            cmd = new SqlCommand("SELECT  NoCarga FROM CARGA WHERE FechaDeCarga = '" + fecha + "'"+" AND HoraCArga= '"+hora+"'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    datos[0] = dr["NoCarga"].ToString();




                }
                else
                {
                    HttpContext.Current.Response.Write("<script>window.alert('');</script>");

                }

                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta buscarcarga');</script>");
            }
            return datos;

        }

        public String carga(String fecha,int total,int cargados, int nocargados,String horacarga)
        {
            String salida = "Si se guardo el Usuario";


            try
            {

                cmd = new SqlCommand("Insert into CARGA(FechaDeCArga,TotalProyectos,TotalCargados,TotalNoCargados,HoraCarga) values ('" + fecha + "' , '" + total + "', '" + cargados + "', '" + nocargados + "', '" + horacarga + "')", conexion.conec);
                cmd.ExecuteNonQuery();


              


            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;


        }

        public String detallecarga(int carga, String linea, String estado, String descripcion)
        {
            String salida = "Si se guardo el Usuario";


            try
            {

                cmd = new SqlCommand("Insert into DETALLE_CARGA(NoCarga,LineaCarga,Estado,Descripcion) values ('" + carga + "' , '" + linea + "', '" + estado + "', '" + descripcion + "')", conexion.conec);
                cmd.ExecuteNonQuery();





            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;


        }

        public bool  verificarencargado(String workerid)
        {
            bool salida = false;


            try
            {
                cmd = new SqlCommand("Select * from USUARIO where Workerid = '" + workerid + "' AND Tipo='Administrador'", conexion.conec);
                dr = cmd.ExecuteReader();
                while (dr.Read())


                   
                {
                    salida=true;

                }
                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }



            
            return salida;
        }
        public String Asignarproyecto(String workerid, String projectid)
        {

            String salida = "Si se asigno el Proyecto";

            String codusuario = "";
            String codpro = "";
            cmd = new SqlCommand("SELECT CodigoUsuario FROM USUARIO WHERE Workerid = '" + workerid + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                  codusuario = dr["CodigoUsuario"].ToString();



                }

              
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }



            dr.Close();
            cmd = new SqlCommand("SELECT CodigoProyecto FROM PROYECTO WHERE Projectid = '" + projectid + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    codpro = dr["CodigoProyecto"].ToString();



                }

               
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }

            dr.Close();




            try
            {

                cmd = new SqlCommand("Insert into USUARIO_PROYECTO(CodigoUsuario,CodigoProyecto) values ('" + Convert.ToInt32(codusuario) + "', '" + Convert.ToInt32(codpro) + "')", conexion.conec);
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;



        }
        public String cambiarestadocaso(int cod,String estado) 
        {
            string salida = "Se guardaron los cambios";

            try
            {
                cmd = new SqlCommand("UPDATE CASO SET Estado= '" + estado + "' WHERE CodigoCaso=" + cod + ";", conexion.conec);
                cmd.ExecuteNonQuery();

                String[] datos = new String[7];
                cmd = new SqlCommand("SELECT CodigoCaso,Estado,Situacion,Prioridad,FechaEntrega,Categoria,Descripcion FROM CASO WHERE CodigoCaso = '" + cod + "'", conexion.conec);


                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        datos[0] = dr["CodigoCaso"].ToString();

                        datos[1] = dr["Estado"].ToString();
                        datos[2] = dr["Situacion"].ToString();
                        datos[3] = dr["Prioridad"].ToString();
                        datos[4] = dr["FechaEntrega"].ToString();
                        datos[5] = dr["Categoria"].ToString();
                        datos[6] = dr["Descripcion"].ToString();



                    }
                    dr.Close();
                    insertarcasomodificacion(cod, datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]);

                }
                catch (Exception ex)
                {

                    HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
                }




            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;




        }
        public String cambiarsituacioncaso(int cod, String situacion)
        {
            string salida = "Se guardaron los cambios";

            try
            {
                cmd = new SqlCommand("UPDATE CASO SET Situacion= '" + situacion + "' WHERE CodigoCaso=" + cod + ";", conexion.conec);
                cmd.ExecuteNonQuery();

                String[] datos = new String[7];
                cmd = new SqlCommand("SELECT CodigoCaso,Estado,Situacion,Prioridad,FechaEntrega,Categoria,Descripcion FROM CASO WHERE CodigoCaso = '" + cod + "'", conexion.conec);


                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        datos[0] = dr["CodigoCaso"].ToString();
                       
                        datos[1] = dr["Estado"].ToString();
                        datos[2] = dr["Situacion"].ToString();
                        datos[3] = dr["Prioridad"].ToString();
                        datos[4] = dr["FechaEntrega"].ToString();
                        datos[5] = dr["Categoria"].ToString();
                        datos[6] = dr["Descripcion"].ToString();



                    }
                    dr.Close();
                    insertarcasomodificacion(cod, datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]);
                   
                }
                catch (Exception ex)
                {

                    HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
                }



               
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;




        }
        public String Resolvercaso(String cod)
        {
            cmd = new SqlCommand("SELECT Estado FROM CASO WHERE CodigoCaso = '" + cod + "'", conexion.conec);
            string salida = "";
            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    salida = dr["Estado"].ToString();



                }
                dr.Close();


            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }



            return salida;
        }


        public String Asignarcaso(String workerid, String cod)
        {

            String salida = "Si se asigno el Caso";

            String codusuario = "";
           
            cmd = new SqlCommand("SELECT CodigoUsuario FROM USUARIO WHERE Workerid = '" + workerid + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    codusuario = dr["CodigoUsuario"].ToString();



                }
                dr.Close();

                try
                {

                    cmd = new SqlCommand("Insert into CASO_USUARIO(CodigoUsuario,CodigoCaso) values ('" + Convert.ToInt32(codusuario) + "', '" + Convert.ToInt32(cod) + "')", conexion.conec);
                    cmd.ExecuteNonQuery();




                }
                catch (Exception ex)
                {
                    salida = "No se conecto: " + ex.ToString();

                }

            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }



         

            return salida;



        }

        public String insertarcasomodificacion( int codca, String estado, String situacion, String prioridad, String fechae, String categoria, String descripcion)
        {

            String salida = "Si se guardo la modificacion";


            try
            {

                cmd = new SqlCommand("Insert into MODIFICACION_CASO(CodigoCaso,Estado,Situacion,Prioridad,FechaEntrega,Categoria,Descripcion) values ('" + codca + "', '" + estado + "', '" + situacion + "', '" + prioridad + "', '" + fechae + "', '" + categoria + "', '" + descripcion + "')", conexion.conec);
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;



        }


        public int inciarsesion(String workerid, String contra)
        {
            int cont = 0;




            try
            {
                cmd = new SqlCommand("Select * from USUARIO where Workerid ='" + workerid + "' and Contraseña ='"+contra+"'" , conexion.conec);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cont++;

                }
                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }

            


            return cont;
        }

        public String tipo(String workerid)
        {

            String tipo = "";


            cmd = new SqlCommand("SELECT Tipo FROM USUARIO WHERE Workerid = '" + workerid + "'", conexion.conec);

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                   tipo = dr["Tipo"].ToString();
                   



                }


               
                dr.Close();
            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
            }
           

            return tipo;
        }

        public String recuperar(String correo, String contraseña)
        {
            String datos = "";
            if (contraseña.Equals("juan1234"))
            {

               
                cmd = new SqlCommand("SELECT  Contraseña FROM USUARIO WHERE correo = '" + correo + "'", conexion.conec);

                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.Read() == true)
                    {
                        datos= dr["Contraseña"].ToString();




                    }
                    else
                    {
                        
                        HttpContext.Current.Response.Write("<script>window.alert('El correo no esta registrado');</script>");

                    }
                }
                catch (Exception ex)
                {

                    HttpContext.Current.Response.Write("<script>window.alert('No se pudo hacer la consulta');</script>");
                }
            }
                return datos;
            

        }

        public String cambiar(int cod, String Contraseñanueva)
        {
            string salida = "Se guardaron los cambios";

            try
            {
                cmd = new SqlCommand("UPDATE USUARIO SET Contraseña= '" + Contraseñanueva + "' WHERE CodigoUsuario=" + cod + ";", conexion.conec);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;




        }

        public String eliminarusuario(int cod)
        {
            String salida = "Se elimino";

           

            try
            {
                cmd = new SqlCommand("Delete from CASO_USUARIO WHERE CodigoUsuario='"+cod+"';", conexion.conec);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete from USUARIO_PROYECTO WHERE CodigoUsuario='" + cod + "';", conexion.conec);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete from USUARIO WHERE CodigoUsuario='" + cod + "';", conexion.conec);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;

           


            
        }

        public String eliminarproyecto(int cod)
        {
            String salida = "Se elimino";



            try
            {
                cmd = new SqlCommand("Delete CASO_USUARIO from CASO_USUARIO AS CU, PROYECTO AS P, CASO AS C  WHERE C.CodigoProyecto='" + cod + "' AND C.CodigoCaso=CU.CodigoCaso;", conexion.conec);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete MODIFICACION_CASO from CASO AS C, PROYECTO AS P, MODIFICACION_CASO AS MC  WHERE C.CodigoProyecto='" + cod + "' AND C.CodigoCaso= MC.CodigoCaso;", conexion.conec);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete CASO WHERE CodigoProyecto='" + cod + "';", conexion.conec);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete USUARIO_PROYECTO WHERE CodigoProyecto='" + cod + "';", conexion.conec);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Delete PROYECTO WHERE CodigoProyecto='" + cod + "';", conexion.conec);
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();

            }

            return salida;

           



        }
    }

   
}