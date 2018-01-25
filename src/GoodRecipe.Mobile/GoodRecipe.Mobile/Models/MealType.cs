using System.Collections.Generic;

namespace GoodRecipe.Mobile.Models
{
    public class MealType
    {
        public static string Breakfast = "Café da Manhã";
        public static string Lunch = "Almoço";
        public static string Dinner = "Jantar";
        public static string Snack = "Lanche";

        public static List<string> GetMealsType()
        {
            return new List<string>
            {
               Breakfast,
               Lunch,
               Dinner,
               Snack
            };
        }
    }
}
