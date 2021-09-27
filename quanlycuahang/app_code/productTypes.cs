using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace quanlycuahang
{
    public class productTypes
    {
        public int typeID { get; set; }
        public int cateID { get; set; }
        public string typeName { get; set; }

        public productTypes() { }
        public productTypes(int typeID,int cateID, string typeName) {

            this.typeID = typeID;
            this.cateID = cateID;
            this.typeName = typeName;
        }

    }
}