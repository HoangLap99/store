using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.admin
{
    public partial class editcate : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                categories pro = (categories)Session["sv"];
                txtma.Text = pro.cateID.ToString();
                txtten.Text = pro.cateName;
               
            }
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                categories pro = new categories();
                pro.cateID = int.Parse(txtma.Text);
                pro.cateName= txtten.Text;
                data.editcate(pro);
                msg.Text = "cập nhật Thành Công";
            }
            catch (Exception ex)
            {
                msg.Text = "co loi :" + ex;
            }
        }
    }
}