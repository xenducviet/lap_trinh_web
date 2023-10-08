using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wtbc
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                double A = double.Parse(Request["a"]);
                double B = double.Parse(Request["b"]);
                double C = double.Parse(Request["c"]);
                double D = double.Parse(Request["d"]);

                double kq = (A + B + C + D) / 3.0;

                Response.Write(kq.ToString());
            }
            catch (Exception ex)
            {
                Response.Write("Error: " + ex.Message);
            }
        }
    }
}