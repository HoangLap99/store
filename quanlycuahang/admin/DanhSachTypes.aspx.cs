using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.admin
{
    public partial class DanhSachTypes : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl.DataSource = data.dscate();
                ddl.DataTextField = "cateName";
                ddl.DataValueField = "cateID";
                DataBind();
            }
            Hienthi();
        }

        private void Hienthi()
        {
            grv.DataSource = data.dsTypes();
            DataBind();
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                productTypes pro = new productTypes();
                pro.typeID = int.Parse(txtma.Text);
                pro.cateID = int.Parse(ddl.SelectedValue);
                pro.typeName = txtten.Text;
                data.themtype(pro);
                Hienthi();
                msg.Text = "Thêm Thành Công";
            }
            catch (Exception e1)
            {
                msg.Text = "lỗi" + e1;
            }
        }
        protected void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                string m = Convert.ToString(e.CommandArgument);
                data.xoaType(m);
                Hienthi();
            }
        }
        protected void Sua_click(object sender, CommandEventArgs e)
        {

            if (e.CommandName == "sua")
            {
                string m = Convert.ToString(e.CommandArgument);
                productTypes s = data.layra1type(m);
                Session["sv"] = s;
                Response.Redirect("editTypes.aspx");

            }
        }
    }
}