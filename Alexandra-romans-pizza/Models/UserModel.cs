using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomansPizzaLibrary
{
    public class UserModel
    {
        public string userName { get; set; }
        public string userEmail { get; set; }

        public string userPhone { get; set; }

        public string userAdress { get; set; }

        public UserModel()
        {

        }

        public UserModel( string userName , string userEmail , string userPhone , string userAdress)
        {
            this.userName = userName;
            this.userEmail = userEmail;
            this.userPhone = userPhone;
            this.userAdress = userAdress;

        }


    }


}
