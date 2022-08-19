
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomansPizzaLibrary
{
    public class MealItemModel
    {
        public string mealName { get; set; }
        public int mealPrice { get; set; }

        public string mealPicture { get; set; }

        public string firstOptionTitle { get; set; }
        public string secondOptionTitle { get; set; }
        public string thirdptionTitle { get; set; }



        public List<OptionModel> firstOption { get; set; } = new List<OptionModel>();


        public List<OptionModel> secondOption { get; set; } = new List<OptionModel>();

        
        

        public MealItemModel()
        {

        }

        public MealItemModel(
            String mealName , 
            int mealPrice ,
            string firstOptionTitle, 
            string secondOptionTitle
            )
        {
            this.mealName = mealName;
            this.mealPrice = mealPrice;
            this.firstOptionTitle = firstOptionTitle;
            this.secondOptionTitle = secondOptionTitle;
            
        }

        

    }
}
