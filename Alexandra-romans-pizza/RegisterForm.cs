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
    public partial class RegisterForm : Form
    {

        IUserRequestor requestingForm;

        public RegisterForm(IUserRequestor requestor)
        {
            InitializeComponent();
            requestingForm = requestor;
            
        }

        /*Validate method. 
         Will check if the input from the for is valid*/
        private Boolean ValidateForm()
        {
            if(nameBox.Text.Length == 0)
            {
                MessageBox.Show("Name and surname cannot be empty");
                return false;   
            }

            if (emailBox.Text.Length == 0)
            {
                MessageBox.Show("Please fill in your email");
                return false;
            }

            if (phoneNumberBox.Text.Length == 0)
            {
                MessageBox.Show("Please enter your active phone number, our delivery will be able to reach you");
                return false;
            }

            if (adressbox.Text.Length == 0)
            {
                MessageBox.Show("Please fill in your adress or location");
                return false;
            }

            

            return true;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())

            {
                //create User Model
                UserModel user = new UserModel(
                    nameBox.Text, 
                    emailBox.Text, 
                    phoneNumberBox.Text, 
                    adressbox.Text);

                //send it to the interface  connecting MainForm and this form
                requestingForm.UserCreated(user);

                //close the form
                this.Close();

            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
