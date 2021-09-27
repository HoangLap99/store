using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.marterpage
{
    public partial class client : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String searchText = txttimkiem.Text;
            Response.Redirect("trangchu.aspx?srch=" + searchText);
        }
    }
}