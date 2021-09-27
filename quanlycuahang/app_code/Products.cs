using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlycuahang
{
   
    public class Products
    {
        public string proID { get; set; }
        public int typeID { get; set; }
        public string proName { get; set; }
        public string proSize { get; set; }
        public int proamount { get; set; }
        public double proPrice { get; set; }
        public int proDiscount { get; set; }
        public string proPhoto { get; set; }
        public DateTime proUpdateDate { get; set; }
        public string proDescription { get; set; }
        public Products()
        { }
        public Products(string proID, int typeID, string proName, string proSize,string proPhoto,int proamount, double proPrice,int proDiscount, DateTime proUpdateDate, string proDesciption )
        {
            this.proID = proID;
            this.typeID = typeID;
            this.proName = proName;
            this.proamount = proamount;
            this.proSize = proSize;
            this.proPrice = proPrice;
            this.proDiscount = proDiscount;
            this.proPhoto = proPhoto;
            this.proUpdateDate = proUpdateDate;
            this.proDescription = proDesciption;
        }

        public Products(string proID)
        {
            this.proID = proID;
        }


    }
}