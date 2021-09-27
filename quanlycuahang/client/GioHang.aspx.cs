using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.client
{
    public partial class GioHang : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["tk"] != null)
                {
                    Administrator ad = (Administrator)Session["tk"];
                    string phone = ad.cusPhone;
                    Customer cus = data.lay1cus(phone);
                    txthoten.Text = cus.cusFullName;
                    txtSDT.Text = cus.cusPhone;
                    txtemail.Text = cus.cusEmail;
                    txtdiachi.Text = cus.cusAddress;
                }
                HienThi(); 

            }
        }

        private void HienThi()
        {
           
                if (Session["sl"] == null || (int)Session["sl"] == 0)
                {
                    lblThongBao.Text = "Giỏ hàng rỗng, tiếp tục mua hàng để làm đầy giỏ!";
                    btnDatMua.Visible = false;
                }
                else
                {
                    int SoLuong = (int)Session["sl"];
                    lblThongBao.Text = "Bạn có " + SoLuong + " sản phẩm trong giỏ hàng. Đặt mua ngay kẻo lỡ!";
                    nocart.Visible = false;
                     List<order_details> li = (List<order_details>)Session["giohang"];
                    dlGioHang.DataSource = li;
                    DataBind();
                }
            
        }
        protected void btnXoa_Command(object sender, CommandEventArgs e)
        {
            List<order_details> li = (List<order_details>)Session["giohang"];
            order_details dh = new order_details();
            dh.proID = new Products();
            dh.proID.proID = Convert.ToString(e.CommandArgument);
            int i = li.IndexOf(dh);
            Session["sl"] = (int)Session["sl"] - li[i].ordtsQuantity;
            li.Remove(dh);
            Session["giohang"] = li;
            Response.Redirect("GioHang.aspx");
        }

        protected void mua_click(object sender, ImageClickEventArgs e)
        {
            //Response.Redirect("trangchu.aspx");
                if(txtSDT.Text.Trim().Equals("") && txthoten.Text.Trim().Equals("") && txtdiachi.Text.Trim().Equals(""))
                  {
                Response.Write("<script>alert('Nhập đầy đủ thông tin để mua');</script>");
                   }
                 else { 
                 
                String name = txthoten.Text;
                String sdt = txtSDT.Text;
                String email = txtemail.Text;
                String diaChi = txtdiachi.Text;
                String ghiChu = size.Text;
                string str = DateTime.Now.ToString().Trim();
                Customer cust = data.lay1cus(sdt);
                if (cust == null)
                {
                    Customer cus = new Customer();
                    cus.cusPhone = sdt;
                    cus.cusFullName = name;
                    cus.cusAddress = diaChi;
                    cus.cusEmail = email;
                    data.themCus(cus);
                    String query = "Insert into Orders values( '" + sdt + "', 'Size:" + ghiChu + "', '" + str + "', N'0')";

                    List<order_details> li = (List<order_details>)Session["giohang"];
                    int a = data.themgiohang(query, li);
                    if (a != 0)
                    {
                        Response.Write("<script>alert('Mua Thanh công. Quay lại trang chủ để tiếp tục mua hàng nào');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Mua that bai');</script>");
                    }
                    Session["sl"] = null;
                    Response.Redirect("GioHang.aspx");
                }
                else
                {
                    String query = "Insert into Orders values( '" + sdt + "', 'Size:" + ghiChu + "', '" + str + "', N'0')";

                    List<order_details> li = (List<order_details>)Session["giohang"];
                    int a = data.themgiohang(query, li);
                    if (a != 0)
                    {
                        Response.Write("<script>alert('Mua Thanh công. Quay lại trang chủ để tiếp tục mua hàng nào');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Mua that bai');</script>");
                    }
                    Session["sl"] = null;
                    Response.Redirect("GioHang.aspx");
                }
            
            }

        }

        protected void txthoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}