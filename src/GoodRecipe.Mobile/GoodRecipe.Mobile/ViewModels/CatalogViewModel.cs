using GoodRecipe.Mobile.Data;
using GoodRecipe.Mobile.Models;
using System.Collections.Generic;

namespace GoodRecipe.Mobile.ViewModels
{
    public class CatalogViewModel : BaseViewModel
    {
        static CatalogViewModel instance = new CatalogViewModel();
        public static CatalogViewModel Instance
        {
            get { return instance; }
            private set { instance = value; }
        }

        RecipeRepository RecipeRepository => new RecipeRepository();

        public List<Grouping<string, Recipe>> Recipes { get; set; } = new List<Grouping<string, Recipe>>();

        public void Initialize()
        {
            Recipes = RecipeRepository.GetRecipesGroup();
        }
    }
}
