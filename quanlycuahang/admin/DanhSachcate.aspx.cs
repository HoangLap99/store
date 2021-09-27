using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.admin
{
    public partial class DanhSachcate : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void Hienthi()
        {
            grv.DataSource = data.dscate();
            DataBind();
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                categories cate = new categories();
                cate.cateID = int.Parse(txtma.Text);
                cate.cateName = txtten.Text;
                data.themcate(cate);
                msg.Text = "Thêm Thành Công";
                Hienthi();
            }catch (Exception e1)
            {
                msg.Text = "Lỗi định dạng" +e1;

            }
        }
        protected void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                string m = Convert.ToString(e.CommandArgument);
                data.xoacate(m);
                Hienthi();
            }
        }
        protected void Sua_click(object sender, CommandEventArgs e)
        {

            if (e.CommandName == "sua")
            {
                string m = Convert.ToString(e.CommandArgument);
                categories s = data.layra1cate(m);
                Session["sv"] = s;
                Response.Redirect("editcate.aspx");

            }
        }
    }
}