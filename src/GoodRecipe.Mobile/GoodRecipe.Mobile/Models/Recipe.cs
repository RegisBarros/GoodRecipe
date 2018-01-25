namespace GoodRecipe.Mobile.Models
{
    public class Recipe
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int ReadyInTime { get; set; }

        public int NumberOfServings { get; set; }

        public bool WillMakeAgain { get; set; }

        public string MealType { get; set; }

        public string Ingredients { get; set; }

        public string Directions { get; set; }

        public string Picture { get; set; }

        public bool IsRecommended { get; set; }

        public Category Category { get; set; }

        public string TitleSort
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Title) || Title.Length == 0)
                    return "?";

                return Title[0].ToString().ToUpper();
            }
        }
    }
}
