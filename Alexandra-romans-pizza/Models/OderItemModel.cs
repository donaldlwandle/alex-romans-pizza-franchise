using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomansPizzaLibrary
{
    public class OderItemModel
    {
        public string itemName { get; set; }
        public string item1stOption { get; set; }
        public string item2ndOption { get; set; }
        public int itemPrice { get; set; }

        public int itemQuantity { get; set; }

        

        public OderItemModel()
        {

        }

        public OderItemModel(string itemName,string item1stOption ,string item2ndOption ,int itemPrice ,int itemQuantity )
        {
            this.itemName = itemName;
            this.item1stOption = item1stOption;
            this.item2ndOption = item2ndOption;
            this.itemPrice = itemPrice;
            this.itemQuantity = itemQuantity;
        }

    }
}
