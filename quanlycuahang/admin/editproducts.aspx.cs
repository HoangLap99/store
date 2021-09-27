using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.admin.products
{
    public partial class editproducts : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Products pro = (Products)Session["sv"];
                txtmasp.Text = pro.proID;
                ddlloai.DataSource = data.dsTypes();
                ddlloai.DataTextField = "typeName";
                ddlloai.DataValueField = "typeID";
                DataBind();
                ddlloai.SelectedValue =pro.typeID.ToString();
                txttensanpham.Text= pro.proName;
                Txtkichthuoc.Text = pro.proSize;
                Txtsoluong.Text=pro.proamount.ToString();
                txtgiatien.Text= pro.proPrice.ToString();
                Txtgiamgia.Text= pro.proDiscount.ToString();
                Txthinhanh.Text=pro.proPhoto;
                string fname = pro.proPhoto;
                Image1.ImageUrl = "~/images/" + fname;
                Txtngaynhap.Text= pro.proUpdateDate.ToString();
                Txtmota.Text= pro.proDescription;
            }
        }

        protected void btnsua_Click(object sender, EventArgs e)
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
                string fname = fhinhanh.FileName;
                if (fname != "")
                {
                    pro.proPhoto = fhinhanh.FileName;
                    
                    fhinhanh.PostedFile.SaveAs(Server.MapPath("~/images") + @"\" + fname);

                }
                else
                {
                    pro.proPhoto = Txthinhanh.Text;
                }
                string str = DateTime.Now.ToString().Trim();
                pro.proUpdateDate = DateTime.Parse(str);
                pro.proDescription = Txtmota.Text;
                data.editproducts(pro);


                msg.Text = "cập nhật Thành Công";
            }
                catch (Exception ex)
                {
                    msg.Text = "co loi :" + ex;
                }


        }

        protected void btnquaylai_Click(object sender, EventArgs e)
        {

        }
    }
}