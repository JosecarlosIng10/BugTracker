﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class UsuariosWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ((Session["usuario"].ToString().Equals("SuperUsuario")) || (Session["usuario"].ToString().Equals("Administrador")))
                {

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
    }
}