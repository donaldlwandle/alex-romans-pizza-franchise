using RomansPizzaLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandra_romans_pizza
{
    public partial class BagForm : Form

    {
        List<OderItemModel> oderItemslist;
   
        private int totalPrice =0;
        public BagForm(List<OderItemModel> oderItemModel)
        {
            InitializeComponent();
            oderItemslist = oderItemModel;

            foreach(OderItemModel item in oderItemslist)
            {
                
                this.cartBox.Items.Add(item.itemName + "               : R" + item.itemPrice);
                totalPrice += item.itemPrice;
            }

            totalPriceLabel.Text = "Total : R" + totalPrice;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {

        }
    }
}
