using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlycuahang
{
    public class categories
    {
        public int cateID { get; set; }
        public string cateName { get; set; }
        public categories() { }
        public categories(int cateID, string cateName)
        {
            this.cateID = cateID;
            this.cateName = cateName;
        }
    }
}