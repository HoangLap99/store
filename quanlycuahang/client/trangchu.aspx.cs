using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.client
{
    public partial class trangchu : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["srch"] != null)
            { 
                String s = (String)Request.QueryString["srch"];
                if (data.DSSPTK(s).Count() == 0)
                {
                    Response.Write("<script>alert('Không có sản phẩm cần tìm');</script>");
                }
                else
                {
                    DataList1.DataSource = data.DSSPTK(s);
                    DataBind();
                   
                }
            }
            else if(!IsPostBack)
            {
                DataList1.DataSource = data.DSSP();
                DataBind();
            }    
        }
        protected void Xem_click(object sender, CommandEventArgs e)
        {

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