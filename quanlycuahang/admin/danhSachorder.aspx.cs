using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.admin
{
    public partial class danhSachorder : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void Hienthi()
        {
            grv.DataSource = data.dsOrders();
            DataBind();
        }
        protected void Sua_click(object sender, CommandEventArgs e)
        {

            if (e.CommandName == "sua")
            {
                string m = Convert.ToString(e.CommandArgument);
                Orders s = data.layra1order(m);
                Session["sv"] = s;
                Response.Redirect("chiTietHoaDon.aspx");
            }
        }
    }
}