using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb1.Models
{
    public class StockModel
    {
        public string id { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public byte[] picture { get; set; }
        public int stock_quantity_hq { get; set; }
        public string stock_location_hq { get; set; }
        public int stock_quantity_rbo { get; set; }
        public string stock_location_rbo { get; set; }
        public int stock_quantity_kbo { get; set; }
        public string stock_location_kbo { get; set; }
        public string unit { get; set; }
    }
}
