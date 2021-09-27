using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.client
{
    public partial class giaythoitrang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void Xem_click(object sender, CommandEventArgs e)
        {
            DataUtil data = new DataUtil();

            if (e.CommandName == "xem")
            {
                string m = Convert.ToString(e.CommandArgument);
                Products s = data.layra1products(m);
                Session["num"] = s;
                Response.Redirect("Xemsanpham.aspx");

            }
        }
    }
}