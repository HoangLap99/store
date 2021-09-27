using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.admin
{
    public partial class chiTietHoaDon : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Orders pro = (Orders)Session["sv"];
                Txtsdt.Text = pro.cusPhone;
                txtsize.Text = pro.orderMessage;
                txttime.Text = pro.orderDateTime;
                txttrangthai.Text = pro.orderStatus;
                Customer cus= data.lay1cus(pro.cusPhone);
                txtten.Text = cus.cusFullName;

                Hienthi();

            }
        }

        private void Hienthi()
        {
            Orders pro = (Orders)Session["sv"];
            gvchitietdonhang.DataSource = data.dsOrd(pro.orderID);
            DataBind();
        }
    }
}