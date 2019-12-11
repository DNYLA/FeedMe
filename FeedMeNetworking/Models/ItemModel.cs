using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeNetworking.Models
{
    public class ItemModel2
    {
        public int ItemID { get; set; } = 0;
        public int VendorID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 0;
        public int Price { get; set; } = 0;
        public Decimal TotalPrice { get; set; } = 0;
    }
}
