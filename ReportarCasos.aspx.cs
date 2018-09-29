using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BugTracker
{
    public partial class ReportarCasos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["usuario"].ToString() != "")
                {
                    Label1.Text = "Fecha " + DateTime.Now.ToString("d") + " Hora " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();

                }
            }
            catch
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataView dv = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            DataRowView drv = dv[0];

            Table1.Rows[1].Cells[0].Text = drv["BUGS"].ToString();

            DataView dv1 = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);
            DataRowView drv1 = dv1[0];

            Table1.Rows[1].Cells[1].Text = drv1["BUGS"].ToString();

            DataView dv2 = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
            DataRowView drv2 = dv2[0];

            Table1.Rows[1].Cells[2].Text = drv2["BUGS"].ToString();

            DataView dv3 = (DataView)SqlDataSource4.Select(DataSourceSelectArguments.Empty);
            DataRowView drv3 = dv3[0];

            Table1.Rows[1].Cells[3].Text = drv3["BUGS"].ToString();

           DataView dv5 = (DataView)SqlDataSource5.Select(DataSourceSelectArguments.Empty);
            DataRowView drv5 = dv5[0];

            Table2.Rows[1].Cells[0].Text = drv5["BUGS"].ToString();

            DataView dv6 = (DataView)SqlDataSource6.Select(DataSourceSelectArguments.Empty);
            DataRowView drv6 = dv6[0];

            Table2.Rows[1].Cells[1].Text = drv6["BUGS"].ToString();

            DataView dv7 = (DataView)SqlDataSource7.Select(DataSourceSelectArguments.Empty);
            DataRowView drv7 = dv7[0];

            Table2.Rows[1].Cells[2].Text = drv7["BUGS"].ToString();

            DataView dv8 = (DataView)SqlDataSource8.Select(DataSourceSelectArguments.Empty);
            DataRowView drv8 = dv8[0];

            Table2.Rows[1].Cells[3].Text = drv8["BUGS"].ToString();

            DataView dv9 = (DataView)SqlDataSource9.Select(DataSourceSelectArguments.Empty);
            DataRowView drv9 = dv9[0];

            Table3.Rows[1].Cells[0].Text = drv9["BUGS"].ToString();

            DataView dv10 = (DataView)SqlDataSource10.Select(DataSourceSelectArguments.Empty);
            DataRowView drv10 = dv10[0];

            Table3.Rows[1].Cells[1].Text = drv10["BUGS"].ToString();

            DataView dv11 = (DataView)SqlDataSource11.Select(DataSourceSelectArguments.Empty);
            DataRowView drv11 = dv11[0];

            Table3.Rows[1].Cells[2].Text = drv11["BUGS"].ToString();

            DataView dv12 = (DataView)SqlDataSource12.Select(DataSourceSelectArguments.Empty);
            DataRowView drv12 = dv12[0];

            Table3.Rows[1].Cells[3].Text = drv12["BUGS"].ToString();
        }
    }
}