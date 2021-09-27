using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlycuahang
{
    public class Administrator
    {
        public string cusPhone { get; set; }
        public string adPass { get; set; }

        public Administrator() { }
        public Administrator(string name, string pass) {
            this.cusPhone = name;
            this.adPass = pass;
        }
    }
}