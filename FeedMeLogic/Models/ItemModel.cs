using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedMeLogic.Models
{
    public class ItemModel
    {
        public int ItemID { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public int Price { get; set; } = 0;
        public Decimal TotalPrice { get; set; } = 0;
    }
}
