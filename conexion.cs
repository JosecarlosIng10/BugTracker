using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BugTracker
{
     class conexion
    {
        public SqlConnection conec; 
        


        public SqlConnection getSqlConnection()
        {

            return this.conec;

        }
        public conexion()
        {

            try
            {
                conec = new SqlConnection("Data Source=EQUIPO-VAIO\\sqlexpress;Initial Catalog=BDbugtracker;Integrated Security=True");
                conec.Open();

                


            }
            catch (SqlException e)
            {

            }
            catch (Exception ex)
            {

                HttpContext.Current.Response.Write("<script>window.alert('No se ha conectado a la base de datos');</script>");
            }
        }

    }
   

}