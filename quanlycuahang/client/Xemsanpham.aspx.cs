using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.client
{
    public partial class Xemsanpham : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Products pro = (Products)Session["num"];
                lbten.Text = pro.proName;
                lbma.Text = pro.proID;
                double tien = pro.proPrice;
                if(pro.proDiscount!=0)
                {
                    tien = tien *(100 - pro.proDiscount) /100;
                }
                lbgia.Text = tien.ToString();
                lbsize.Text = pro.proSize;
                string fname = pro.proPhoto;
                Image1.ImageUrl = "~/images/" + fname;
                lbmota.Text = pro.proDescription;
            }
        }
        
        protected void GioHang_click(object sender, ImageClickEventArgs e)
        {
            
            Products pro = (Products)Session["num"];
            string ma = pro.proID;
            Products p = data.layra1products(ma);
            if (p.proamount > 0)
            {
                 List<order_details> li = (List<order_details>)Session["giohang"];
                if (li == null)
                {
                    li = new List<order_details>();
                    Session["sl"] = 0;
                }
                order_details dh = new order_details();
                dh.proID = data.layra1products(ma);
                dh.ordtsQuantity = 1;
                dh.ordtsThanhTien = ((double)p.proPrice * (100 - p.proDiscount)/100).ToString();
                if (!li.Contains(dh)) { li.Add(dh); }
                else
                {
                    int i = li.IndexOf(dh);
                    li[i].ordtsQuantity++;
                }

                Session["giohang"] = li;
                Session["sl"] = (int)Session["sl"] + 1;

                Response.Write("<script>alert('Đã thêm vào giỏ hàng');</script>");
            }
            else
            {
                Response.Write("<script>alert('Xin lỗi! Sản phẩm đang hết hàng!');</script>");
            }
        }
    }
}