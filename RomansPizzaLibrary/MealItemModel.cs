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

        public List<String> firstOption { get; set; }


        public List<String> secondOption { get; set; }

        public List<String> thirdOption { get; set; }

        

    }
}
