// Developer  : DL Ntuli
// Date : 15/ August/ 2022
// Title: Alexandras Ramans Pizza Ordering App
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
        UserModel customer;
   
        private int totalPrice =0;
        public BagForm(List<OderItemModel> oderItemModel , UserModel userModel)
        {
            InitializeComponent();
            oderItemslist = oderItemModel;
            customer = userModel;

            PopulateCustomerDetails();
            PopulateOrderList();


        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateCustomerDetails()
        {
            userNameLabel.Text = customer.userName;
            emailLabel.Text = customer.userEmail;
            phoneNoLabel.Text = customer.userPhone;
            adressLabel.Text = customer.userAdress;
        }

        private void PopulateOrderList()
        {
            foreach (OderItemModel item in oderItemslist)
            {

                this.cartBox.Items.Add(item.itemName + "               : R" + item.itemPrice);
                totalPrice += item.itemPrice;
            }

            totalPriceLabel.Text = "Total : R" + totalPrice;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
