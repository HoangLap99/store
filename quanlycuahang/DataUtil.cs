using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;

namespace quanlycuahang
{
    public class DataUtil
    {
        SqlConnection con;
        public DataUtil()
        {
            string sqlcon = "Data Source=.;Initial Catalog=DataShop;Integrated Security=True";
            con = new SqlConnection(sqlcon);

        }
        public List<Products> dssanpham()
        {
            List<Products> ds = new List<Products>();
            string sql = "select* from Products ";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Products pro = new Products();
                pro.proID = (string)rd["proID"];
                pro.typeID = (int)rd["typeID"];
                pro.proName = (string)rd["proName"];
                pro.proSize = (string)rd["proSize"];
                pro.proamount = (int)rd["proamount"];
                pro.proPrice = (double)rd["proPrice"];
                pro.proDiscount = (int)rd["proDiscount"];
                pro.proPhoto = (string)rd["proPhoto"];
                pro.proUpdateDate = (DateTime)rd["proUpdateDate"];
                pro.proDescription = (string)rd["proDescription"];
                ds.Add(pro);
            }
            con.Close();
            return ds;
        }
        public List<Class1> DSSP()
        { 
            List<Class1> ds = new List<Class1>();
            string sql = "SELECT * FROM Products WHERE typeID LIKE @typeID";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("typeID", 2);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Class1 pro = new Class1();
                pro.proID = (string)rd["proID"];
                pro.typeID = (int)rd["typeID"];
                pro.proName = (string)rd["proName"];
                pro.proSize = (string)rd["proSize"];
                pro.proamount = (int)rd["proamount"];
                pro.proPrice = (double)rd["proPrice"];
                pro.proDiscount = (int)rd["proDiscount"];
                pro.proPhoto = (string)rd["proPhoto"];
                pro.proUpdateDate = (DateTime)rd["proUpdateDate"];
                pro.proDescription = (string)rd["proDescription"];
                ds.Add(pro);
            }
            con.Close();
            return ds;
        }
        public List<Class1> DSSPTK(String proName)
        {
            proName = "%" + proName + "%";
            List<Class1> ds = new List<Class1>();
            string sql = "SELECT * FROM Products WHERE proName LIKE @proName";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("proName", proName);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Class1 pro = new Class1();
                pro.proID = (string)rd["proID"];
                pro.typeID = (int)rd["typeID"];
                pro.proName = (string)rd["proName"];
                pro.proSize = (string)rd["proSize"];
                pro.proamount = (int)rd["proamount"];
                pro.proPrice = (double)rd["proPrice"];
                pro.proDiscount = (int)rd["proDiscount"];
                pro.proPhoto = (string)rd["proPhoto"];
                pro.proUpdateDate = (DateTime)rd["proUpdateDate"];
                pro.proDescription = (string)rd["proDescription"];
                ds.Add(pro);
            }
            con.Close();
            return ds;
        }
            public List<categories> dscate()
        {
            List<categories> ds = new List<categories>();
            string sql = "select* from Categories";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                categories pro = new categories();
                pro.cateID = (int)rd["cateID"];
                pro.cateName = (string)rd["cateName"];
                ds.Add(pro);
            }
            con.Close();
            return ds;
        }
        public void themcate(categories pro)
        {
            con.Open();
            string sql = "insert into Categories values (@cateID,@cateName)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cateID", pro.cateID);
            cmd.Parameters.AddWithValue("cateName", pro.cateName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoacate(string cateID)

        {
            con.Open();
            string sql = "delete from Categories where proID=@proID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cateID", cateID);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public categories layra1cate(string cateID)
        {
            List<categories> ds = new List<categories>();
            string sql = "select * from Categories where cateID=@cateID";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cateID", cateID);
            categories s = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                s = new categories();
                s.cateID = (int)rd["cateID"];
                s.cateName = (string)rd["cateName"];
               
            }
            con.Close();
            return s;
        }
        public void editcate(categories pro)
        {
            con.Open();
            string sql = "update Categories set cateID=@cateID,cateName=@cateName";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cateID", pro.cateID);
            cmd.Parameters.AddWithValue("cateName", pro.cateName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void themproducts(Products pro)
        {
            con.Open();
            string sql = "insert into Products values (	@proID,@typeID,@proName,@proSize,@proamount ,@proPrice ,@proDiscount,@proPhoto,@proUpdateDate,@proDescription)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("proID", pro.proID);
            cmd.Parameters.AddWithValue("typeID", pro.typeID);
            cmd.Parameters.AddWithValue("proName", pro.proName);
            cmd.Parameters.AddWithValue("proSize", pro.proSize);
            cmd.Parameters.AddWithValue("proamount", pro.proamount);
            cmd.Parameters.AddWithValue("proPrice", pro.proPrice);
            cmd.Parameters.AddWithValue("proDiscount", pro.proDiscount);
            cmd.Parameters.AddWithValue("proPhoto", pro.proPhoto);
            cmd.Parameters.AddWithValue("proUpdateDate", pro.proUpdateDate);
            cmd.Parameters.AddWithValue("proDescription", pro.proDescription);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void xoaproducts(string proID)

        {
            con.Open();
            string sql = "delete from Products where proID=@proID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("proID", proID);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public Products layra1products(string proID)
        {
            List<Products> ds = new List<Products>();
            string sql = "select * from Products where proID=@proID";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("proID", proID);
            Products s = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                s = new Products();
                s.proID = (string)rd["proID"];
                s.typeID = (int)rd["typeID"];
                s.proName = (string)rd["proName"];
                s.proSize = (string)rd["proSize"];
                s.proamount = (int)rd["proamount"];
                s.proPrice = (double)rd["proPrice"];
                s.proDiscount = (int)rd["proDiscount"];
                s.proPhoto = (string)rd["proPhoto"];
                s.proUpdateDate = (DateTime)rd["proUpdateDate"];
                s.proDescription = (string)rd["proDescription"];
            }
            con.Close();
            return s;
        }
        public void editproducts(Products pro)
        {
            con.Open();
            string sql = "update Products set proID=@proID,typeID=@typeID,proName=@proName,proSize=@proSize," +
                "proamount=@proamount ,proPrice=@proPrice ,proDiscount=@proDiscount,proPhoto=@proPhoto," +
                "proUpdateDate=@proUpdateDate,proDescription=@proDescription where proID=@proID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("proID", pro.proID);
            cmd.Parameters.AddWithValue("typeID", pro.typeID);
            cmd.Parameters.AddWithValue("proName", pro.proName);
            cmd.Parameters.AddWithValue("proSize", pro.proSize);
            cmd.Parameters.AddWithValue("proamount", pro.proamount);
            cmd.Parameters.AddWithValue("proPrice", pro.proPrice);
            cmd.Parameters.AddWithValue("proDiscount", pro.proDiscount);
            cmd.Parameters.AddWithValue("proPhoto", pro.proPhoto);
            cmd.Parameters.AddWithValue("proUpdateDate", pro.proUpdateDate);
            cmd.Parameters.AddWithValue("proDescription", pro.proDescription);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<productTypes> dsTypes()
        {
            List<productTypes> ds = new List<productTypes>();
            string sql = "select* from productTypes";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                productTypes types = new productTypes();
                types.typeID = (int)rd["typeID"];
                types.cateID = (int)rd["cateID"];
                types.typeName = (string)rd["typeName"];
                ds.Add(types);
            }
            con.Close();
            return ds;
        }
        public void themtype(productTypes pro)
        {
            con.Open();
            string sql = "insert into productTypes values (@typeID,@typeName)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("typeID", pro.typeID);
            cmd.Parameters.AddWithValue("cateID", pro.cateID);
            cmd.Parameters.AddWithValue("typeName", pro.typeName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoaType(string typeID)

        {
            con.Open();
            string sql = "delete from productTypes where typeID=@typeID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("typeID", typeID);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public productTypes layra1type(string typeID)
        {
            List<productTypes> ds = new List<productTypes>();
            string sql = "select * from productTypes where typeID=@typeID";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("typeID", typeID);
            productTypes s = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                s = new productTypes();
                s.typeID = (int)rd["typeID"];
                s.cateID = (int)rd["cateID"];
                s.typeName = (string)rd["typeName"];

            }
            con.Close();
            return s;
        }
        public void edittype(productTypes pro)
        {
            con.Open();
            string sql = "update productTypes set typeID=@typeID,typeName=@typeName,cateID=@cateID";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("typeID", pro.typeID);
            cmd.Parameters.AddWithValue("cateID", pro.cateID);
            cmd.Parameters.AddWithValue("typeName", pro.typeName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<Orders> dsOrders()
        {
            List<Orders> ds = new List<Orders>();
            string sql = "select* from Orders";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Orders or = new Orders();
                or.orderID = (int)rd["orderID"];
                or.cusPhone = (string)rd["cusPhone"];
                or.orderMessage = (string)rd["orderMessage"];
                or.orderDateTime = (string)rd["orderDateTime"];
                or.orderStatus = (string)rd["orderStatus"];
                ds.Add(or);
            }
            con.Close();
            return ds;
        }
        public Orders layra1order(string orderID)
        {
            List<Orders> ds = new List<Orders>();
            string sql = "select * from Orders where orderID=@orderID";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("orderID", orderID);
            Orders or = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                or = new Orders();
                or.orderID = (int)rd["orderID"];
                or.cusPhone = (string)rd["cusPhone"];
                or.orderMessage = (string)rd["orderMessage"];
                or.orderDateTime = (string)rd["orderDateTime"];
                or.orderStatus = (string)rd["orderStatus"];
            }
            con.Close();
            return or;
        }

        public Customer layra1cus(string cusPhone)
        {
            List<Customer> ds = new List<Customer>();
            string sql = "select * from Customer where cusPhone=@cusPhone";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cusPhone", cusPhone);
            Customer cus = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                cus = new Customer();
                cus.cusPhone = (string)rd["cusPhone"];
                cus.cusFullName = (string)rd["cusFullName"];
                cus.cusEmail = (string)rd["cusEmail"];
                cus.cusAddress = (string)rd["cusAddress"];
            }
            con.Close();
            return cus;

        }
        public List<order_details> dsOrd(int id)
        {
            List<order_details> ds = new List<order_details>();
            string sql = "select* from OrderDetails where [orderID] = " + id;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                order_details or = new order_details();
                or.orderID = (int)rd["orderID"];
                or.proIdd = (string)rd["proID"];
                or.ordtsQuantity = (int)rd["ordtsQuantity"];
                or.ordtsThanhTien = (string)rd["ordtsThanhTien"];
                ds.Add(or);
            }
            con.Close();
            return ds;
        }
        public void themorder(order_details pro)
        {
            con.Open();
            string sql = "insert into Products values (	@orderID,@proID,@,@ordtsQuantity,@ordtsThanhTien)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("orderID", pro.orderID);
            cmd.Parameters.AddWithValue("proID", pro.proID.proID);
            cmd.Parameters.AddWithValue("ordtsQuantity", pro.ordtsQuantity);
            cmd.Parameters.AddWithValue("ordtsThanhTien", pro.ordtsThanhTien);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public order_details lay1orderdetail(Products proID)
        {
            List<order_details> ds = new List<order_details>();
            string sql = "select * from order_details where proID=@proID";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("proID", proID);
            order_details or = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                or = new order_details();
                or.orderID = (int)rd["orderID"];
                or.proID.proID = (string)rd["Products.proID"];
                or.ordtsQuantity = (int)rd["ordtsQuantity"];
                or.ordtsThanhTien = (string)rd["ordtsThanhTien"];
            }
            con.Close();
            return or;
        }
        public List<Customer> dsCus()
        {
            List<Customer> ds = new List<Customer>();
            string sql = "select* from Customers";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Customer cus = new Customer();
                cus.cusPhone = (string)rd["cusPhone"];
                cus.cusFullName = (string)rd["cusFullName"];
                cus.cusEmail = (string)rd["cusEmail"];
                cus.cusAddress = (string)rd["cusAddress"];

                ds.Add(cus);
            }
            con.Close();
            return ds;
        }
        public void themCus(Customer tk)
        {
            con.Open();
            string sql = "insert into Customers values (@phone,@ten,@email,@diachi)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("phone", tk.cusPhone);
            cmd.Parameters.AddWithValue("ten", tk.cusFullName);
            cmd.Parameters.AddWithValue("email", tk.cusEmail);
            cmd.Parameters.AddWithValue("diachi", tk.cusAddress);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Customer lay1cus(string cusPhone)
        {
            List<Customer> ds = new List<Customer>();
            string sql = "select * from Customers where cusPhone=@cusPhone";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cusPhone", cusPhone);
            Customer s = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                s = new Customer();
                s.cusPhone = (string)rd["cusPhone"];
                s.cusFullName = (string)rd["cusFullName"];
                s.cusEmail = (string)rd["cusEmail"];
                s.cusAddress = (string)rd["cusAddress"];
            }
            con.Close();
            return s;
        }
        public Administrator lay1admin(string cusPhone)
        {
            List<Administrator> ds = new List<Administrator>();
            string sql = "select * from Administrator where cusPhone=@cusPhone";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("cusPhone", cusPhone);
            Administrator s = null;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                s = new Administrator();
                s.cusPhone = (string)rd["cusPhone"];
                s.adPass = (string)rd["adPass"];
              
            }
            con.Close();
            return s;
        }
        public Administrator getTaikhoan(string ten)
        {
            con.Open();
            string sql = "select* from Administrator where cusPhone='" + ten + "'";
            var cmd = new SqlCommand(sql, con);
            var rd = cmd.ExecuteReader();
            Administrator tk = new Administrator();
            if (rd.Read())
            {
                tk.cusPhone = (string)rd["cusPhone"];
                tk.adPass = (string)rd["adPass"];

            }
            con.Close();
            return tk;
        }
        //them tai khoan
        public void themtaikhoan(Administrator tk)
        {
            con.Open();
            string sql = "insert into Administrator values (@ten,@mk)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ten", tk.cusPhone);
            cmd.Parameters.AddWithValue("mk", tk.adPass);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        //Them gio hang
        public int themgiohang(String sql, List<order_details> lst)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            int id = getOrderById();
            con.Open();
            String query = null;
            foreach(order_details item in lst)
            {
                query += "Insert into OrderDetails values("+id+", '"+item.proID.proID+"', "+item.ordtsQuantity+", '"+item.ordtsThanhTien+"')";
            }

            SqlCommand cmd1 = new SqlCommand(query, con);
            int state = cmd1.ExecuteNonQuery();
            con.Close();

            return state;
        }

        public int getOrderById()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select top 1 [orderID] from [dbo].[Orders] order by[orderID] desc", con);
            SqlDataReader rd = cmd.ExecuteReader();
            int id = -1;
            while (rd.Read())
            {
               id = (int)rd[0];
            }
            con.Close();

            return id;
        }
    }
}