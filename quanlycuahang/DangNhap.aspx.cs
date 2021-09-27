using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang
{
    public partial class DangNhap : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndangnhap_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;
            Administrator tk = new Administrator();

            
            if(user=="Admin" && pass=="Admin")
            {
                Response.Redirect("~/admin/DanhSachPro.aspx");
             
            }
            else
            {
                tk = data.lay1admin(user);
                if(tk==null)
                {
                    Response.Write("<script>alert('sai số điện thoại! Mời nhập lại');</script>");
                } 
                else if(tk.adPass!=pass)
                {
                    Response.Write("<script>alert('Sai mật khẩu! Mời nhập lại');</script>");
                }
                else
                {
                    Session["tk"] = tk;
                    Response.Redirect("~/client/trangchu.aspx");

                }    
            }    

        }
    }
}