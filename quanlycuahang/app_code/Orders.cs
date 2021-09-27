using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlycuahang
{
    public class Orders
    {
        public int orderID { get; set; }
        public string cusPhone { get; set; }
        public string orderMessage { get; set; }
        public string orderDateTime { get; set; }
        public string orderStatus { get; set; }

        public Orders()
        { }
        public Orders(int id, string phone, string tn, string time, string status)
        {
            this.orderID = id;
            this.cusPhone = phone;
            this.orderMessage = tn;
            this.orderDateTime = time;
            this.orderStatus = status;
        }
    }
}