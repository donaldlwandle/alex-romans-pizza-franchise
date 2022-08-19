
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
    public partial class MainForm : Form , IUserRequestor ,IOrderRequestor
    {
        UserModel user;
        MealItemModel pizzaMeal , otherMeal , drinks ;
        List<OderItemModel> orderItems = new List<OderItemModel>() ;
        
        public static MainForm instance;

        

        
        public MainForm()
        {
            InitializeComponent();
            instance = this;
            createMenuItems();

            
        }

        private void pizzasLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void createMenuItems()
        {
            //create MainMeal item
            pizzaMeal = new MealItemModel( "Main Meal" , 80, "Flavor" ,"Size");

            //create other meals item
            otherMeal = new MealItemModel("Other Meals", 50, "Select meal" , "Size" );
            

            // create drinks items
            drinks = new MealItemModel("Drinks", 12, "Select Drink" ,"Size" );
            



            
        }

        private  void AddOrder( MealItemModel mealItem)
        {
            
            if(user != null && user.userName.Length > 1)
            {
                //Open add Order Form
                OrderForm orderForm = new OrderForm(mealItem , this);
                
                orderForm.ShowDialog();
            }
            else
            {
                /// Open RegisterForm
                RegisterForm registerForm = new RegisterForm(this);
                registerForm.ShowDialog();
            }
        }



        public void UserCreated(UserModel userModel)
        {
            // asign the created user
            user = userModel;

            
        }

        private void initializeList()
        {

        }


        private void addPizzaBtn_Click(object sender, EventArgs e)
        {

            List<OptionModel> option1List = new List<OptionModel>();
            option1List.Add(new OptionModel( "Main Meal", 0));
            option1List.Add(new OptionModel("Margherita : +R7", 7));
            option1List.Add(new OptionModel("BBQ Chicken : +R11", 11));
            option1List.Add(new OptionModel("Chicken & Mushroom : +R11", 11));
            option1List.Add(new OptionModel("Garlic Bacon : +R20", 20));

            List<OptionModel> option2List = new List<OptionModel>();
            option2List.Add(new OptionModel("Small ", 0));
            option2List.Add(new OptionModel("Medium : R105 ", 25));
            option2List.Add(new OptionModel("Large  : R120 ", 40));



            pizzaMeal.firstOption = option1List;
            pizzaMeal.secondOption = option2List;

            AddOrder(pizzaMeal);




        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void addOtherMealBtn_Click(object sender, EventArgs e)
        {
            List<OptionModel> option1List = new List<OptionModel>();
            option1List.Add(new OptionModel("BBQ Chicken wings : R50", 0));
            option1List.Add(new OptionModel("Cheese grillers : R50", 0));
            option1List.Add(new OptionModel("Hot wings : R 46", -4));
            option1List.Add(new OptionModel("Romans hell's chips : R15", -35));
            

            List<OptionModel> option2List = new List<OptionModel>();
            option2List.Add(new OptionModel("Small ", 0));
            option2List.Add(new OptionModel("Medium : +R10 ", 10));
            option2List.Add(new OptionModel("Large  : +R18 ", 18));



            otherMeal.firstOption = option1List;
            otherMeal.secondOption = option2List;

            
            AddOrder(otherMeal);
        }

        private void orderBag_Click(object sender, EventArgs e)
        {
            //start bag form
            if(orderItems.Count > 0)
            {
                BagForm bagForm = new BagForm(orderItems);
                bagForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your Bag is Empty ,Click Add button to place an Order");
            }
            
        }

        private void addDrinksBtn_Click(object sender, EventArgs e)
        {
            List<OptionModel> option1List = new List<OptionModel>();
            option1List.Add(new OptionModel("Coke : R12", 0));
            option1List.Add(new OptionModel("Fanta : R12", 0));
            option1List.Add(new OptionModel("Aqua Monte : R 11", -1));
            option1List.Add(new OptionModel("Play energy drink : R15", 3));


            List<OptionModel> option2List = new List<OptionModel>();
            option2List.Add(new OptionModel("250ml ", 0));
            option2List.Add(new OptionModel("330ml : +R2 ", 2));
            option2List.Add(new OptionModel("440ml  : +R4 ", 4));



            drinks.firstOption = option1List;
            drinks.secondOption = option2List;


            
            AddOrder(drinks);
        }

        public void OrderCreated(OderItemModel oderItemModel)
        {
            orderItems.Add(oderItemModel);
            orderSizeLabel.Text = "" + orderItems.Count();
            MessageBox.Show("Item added to your Bag, Click the bag Icon to view your bag and checkout");
        }
    }
}
