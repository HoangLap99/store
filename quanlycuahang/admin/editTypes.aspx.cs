using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace quanlycuahang.admin
{
    public partial class editTypes : System.Web.UI.Page
    {
        DataUtil data = new DataUtil();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                productTypes pro = (productTypes)Session["sv"];
                txtma.Text = pro.typeID.ToString();
                ddl.DataSource = data.dscate();
                ddl.DataTextField = "cateName";
                ddl.DataValueField = "cateID";
                DataBind();
                ddl.SelectedValue = pro.cateID.ToString();
                txtten.Text = pro.typeName;
            }
        }

        protected void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                productTypes pro = new productTypes();
                pro.typeID = int.Parse(txtma.Text);
                pro.cateID = int.Parse(ddl.SelectedValue);
                pro.typeName = txtten.Text;
                data.edittype(pro);


                msg.Text = "cập nhật Thành Công";
            }
            catch (Exception ex)
            {
                msg.Text = "co loi :" + ex;
            }
        }
    }
}