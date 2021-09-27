using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace quanlycuahang.admin.products
{
    public partial class Danhsach : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            Hienthi();
            if (!IsPostBack)
            {
                ddlloai.DataSource = data.dsTypes();
                ddlloai.DataTextField = "typeName";
                ddlloai.DataValueField = "typeID";
                DataBind();
              
            }
        }

        private void Hienthi()
        {   
                grdDs.DataSource = data.dssanpham();
                DataBind();
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                Products pro = new Products();
                pro.proID = txtmasp.Text;
                pro.typeID = int.Parse(ddlloai.SelectedValue);
                pro.proName = txttensanpham.Text;
                pro.proSize = Txtkichthuoc.Text;
                pro.proamount = int.Parse(Txtsoluong.Text);
                pro.proPrice = double.Parse(txtgiatien.Text);
                pro.proDiscount = int.Parse(Txtgiamgia.Text);
                pro.proPhoto = fhinhanh.FileName;
                string str = DateTime.Now.ToString().Trim();
                pro.proUpdateDate = DateTime.Parse(str);
                pro.proDescription = Txtmota.Text;
                data.themproducts(pro);
                if (fhinhanh.FileName !=null)
                {
                    string fname = fhinhanh.FileName;
                    fhinhanh.PostedFile.SaveAs(Server.MapPath("/images") + @"\" +fname);
                }
                Hienthi();
                msg.Text = "Thêm Thành Công";
            }
            catch(Exception e1)
            {
                msg.Text = "lỗi" +e1;
            }
        }
        protected void Xoa_click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "xoa")
            {
                string m = Convert.ToString(e.CommandArgument);
                data.xoaproducts(m);
                Hienthi();
            }
        }
        protected void Sua_click(object sender, CommandEventArgs e)
        {

            if (e.CommandName == "sua")
            {
                string m = Convert.ToString(e.CommandArgument);
                Products s = data.layra1products(m);
                Session["sv"] = s;
                Response.Redirect("editproducts.aspx");

            }
        }

        protected void grdDs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Btntimkiem_Click(object sender, EventArgs e)
        {
            String s = txttim.Text;
            if (data.DSSPTK(s).Count() == 0)
            {
                Response.Write("<script>alert('Không có sản phẩm cần tìm');</script>");
            }
            else
            {
                grdDs.DataSource = data.DSSPTK(s);
                DataBind();

            }
        }
    }
}