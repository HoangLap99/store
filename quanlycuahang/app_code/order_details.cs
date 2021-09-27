using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlycuahang
{
    public class order_details
    {
        public int orderID { get; set; }
        public Products proID { get; set; }
        public int ordtsQuantity { get; set; }
        public string ordtsThanhTien { get; set; }

        public String proIdd { get; set; }

        public order_details(){}
        public order_details(int id, Products proID, int sl, string tien)
        {
            this.orderID = id;
            this.proID = proID;
            this.ordtsQuantity = sl;
            this.ordtsThanhTien = tien;
        }

    
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            if (proID.proID == ((order_details)obj).proID.proID)
            {
                return true;
            }
            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here

            return base.GetHashCode();
        }
    }
}
