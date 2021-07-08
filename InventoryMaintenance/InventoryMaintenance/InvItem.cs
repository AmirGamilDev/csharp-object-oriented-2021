using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public InvItem()
        {
        }

        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

        public int ItemNo { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
        
        public string GetDisplayText() => ItemNo + "    " + Description + " (" + Price.ToString("c") + ")";

        // above method is equivalent to this:
        //public string GetDisplayText()
        //{
        //    return ItemNo + "    " + Description + " (" + Price.ToString("c") + ")";
        //}
    }
}
