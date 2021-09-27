using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlycuahang
{
    public class Customer
    {
        public string cusPhone { get; set; }
        public string cusFullName { get; set; }
        public string cusEmail { get; set; }
        public string cusAddress { get; set; }

        public Customer() { }
        public Customer(string ten, string phone, string mail, string dd)
        {
            this.cusPhone = phone;
            this.cusFullName = ten;
            this.cusEmail = mail;
            this.cusAddress = dd;
        }
    }
}