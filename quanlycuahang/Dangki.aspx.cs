using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang
{
    public partial class Dangki : System.Web.UI.Page
    {
        DataUtil Data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string phone = txtsdt.Text;
            string ten = Txthoten.Text;
            string email = Txtemail.Text;
            string diachi = txtdiachi.Text;
            string matkhau = Txtpass.Text;
            Customer cus = new Customer();
            Administrator tk = new Administrator();
            cus = Data.lay1cus(txtsdt.Text);
            tk = Data.lay1admin(phone);
            if (Txtpass.Text.Trim().Equals("") || Txthoten.Text.Trim().Equals("") || Txtemail.Text.Trim().Equals("")
                || txtdiachi.Text.Trim().Equals("") || Txtpass.Text.Trim().Equals(""))
            {
                Response.Write("<script>alert('Nhập đầy đủ thông');</script>");
            }
            else
            {
                if (cus != null && tk != null)
                {
                    Response.Write("<script>alert('Bạn Đã có tài khoản mời đăng nhập');</script>");
                    Response.Redirect("DangNhap.aspx");
                }
                else if (cus != null && tk == null)
                {
                    Administrator ad = new Administrator();
                    ad.cusPhone = txtsdt.Text;
                    ad.adPass = Txtpass.Text;
                    Data.themtaikhoan(ad);
                    Response.Write("<script>alert('Đăng kí thành công mời đăng nhập');</script>");
                    Response.Redirect("DangNhap.aspx");
                }
                else if (cus == null && tk == null)
                {
                    Customer cust = new Customer();
                    cust.cusPhone = txtsdt.Text;
                    cust.cusFullName = Txthoten.Text;
                    cust.cusEmail = Txtemail.Text;
                    cust.cusAddress = txtdiachi.Text;
                    Data.themCus(cust);
                    Administrator ad = new Administrator();
                    ad.cusPhone = txtsdt.Text;
                    ad.adPass = Txtpass.Text;
                    Data.themtaikhoan(ad);
                    
                    Response.Write("<script>alert('Đăng kí thành công mời đăng nhập');</script>");
                    Response.Redirect("DangNhap.aspx");
                }

            }

        }
    }
}