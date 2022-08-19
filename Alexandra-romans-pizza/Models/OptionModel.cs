using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomansPizzaLibrary
{
    public class OptionModel
    {
        //public int optionID { get; set; }
        public string optionTitle { get; set; }
        public int optionPrize { get; set; }

        

        public OptionModel()
        {

        }

        public OptionModel( string optionTitle , int optionPrize )
        {
            this.optionTitle = optionTitle;
            this.optionPrize = optionPrize;
            //this.optionID = optionID;

        }


    }


}
