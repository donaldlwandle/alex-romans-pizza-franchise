using RomansPizzaLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexandra_romans_pizza
{
    public interface IMealUpdater
    {
        void MealUpdated(MealItemModel mealItemModel);
    }
}
