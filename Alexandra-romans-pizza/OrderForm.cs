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
    public partial class OrderForm : Form

    {
        IOrderRequestor requestingForm;
        MealItemModel currentMenuItem;
        int price;
        private  int option1Price = 0;
        private int option2Price = 0;
        private int quantity = 1;

        public OrderForm( MealItemModel mealItem , IOrderRequestor orderRequestor)
        {
            InitializeComponent();
            currentMenuItem = mealItem;
            requestingForm = orderRequestor;
            

            if(currentMenuItem != null)
            {

                price = currentMenuItem.mealPrice;
                PopulateTheForm();
            }
        }

        private void firstOptionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            option1Price = currentMenuItem.firstOption.ElementAt(firstOptionBox.SelectedIndex).optionPrize;
            updatePrice();
        }

        private void secondOptionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            option2Price = currentMenuItem.secondOption.ElementAt(secondOptionBox.SelectedIndex).optionPrize;
            updatePrice();

        }

        private void quantityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantity =  int.Parse(this.quantityBox.SelectedItem.ToString());
            updatePrice();
        }

        private void PopulateTheForm()
        {
            
            BindingSource bs = new BindingSource();
            bs.DataSource = new List<int> {1,2,3,4,5,6,7,8,9,10 };
            quantityBox.DataSource = bs;

            itemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            itemNameLabel.Text = currentMenuItem.mealName;
            itemPrizeLabel.Text = "R " + price;
            firstOptionLabel.Text = currentMenuItem.firstOptionTitle;
            secondOptionLabel.Text = currentMenuItem?.secondOptionTitle;

            firstOptionBox.DataSource = currentMenuItem.firstOption;
            firstOptionBox.DisplayMember = "optionTitle";

            secondOptionBox.DataSource = currentMenuItem.secondOption;
            secondOptionBox.DisplayMember = "optionTitle";

            if(currentMenuItem.mealName == "Main Meal")
            {
                itemPicture.Image = Properties.Resources.pizza;
            }

            else if (currentMenuItem.mealName == "Other Meals")
            {
                itemPicture.Image = Properties.Resources.other_meals;
            }

            else 
            {
                itemPicture.Image = Properties.Resources.drinks;
            }


        }

        private void updatePrice()
        {
            price = currentMenuItem.mealPrice;
            price = quantity * (price + option1Price + option2Price);
            itemPrizeLabel.Text = "R " + price;
        }

        private void addToBag()
        {
            //Create order item model
            var item = new OderItemModel(
                itemNameLabel.Text ,
                firstOptionBox.SelectedItem.ToString() ,
                secondOptionBox.SelectedItem.ToString(),
                price ,
                int.Parse(quantityBox.SelectedItem.ToString())
                
                );

            // send it to the interface
            requestingForm.OrderCreated(item);


            //close the form
            this.Close();



        }



        private void addToBagButton_Click(object sender, EventArgs e)
        {
            addToBag();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
