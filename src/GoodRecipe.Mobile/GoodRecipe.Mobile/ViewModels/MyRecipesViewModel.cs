using GoodRecipe.Mobile.Data;
using GoodRecipe.Mobile.Models;
using System.Collections.ObjectModel;

namespace GoodRecipe.Mobile.ViewModels
{
    public class MyRecipesViewModel : BaseViewModel
    {
        RecipeRepository RecipeRepository { get; set; } = new RecipeRepository();

        public ObservableCollection<Grouping<string, Recipe>> Recipes { get; set; } = new ObservableCollection<Grouping<string, Recipe>>();

        public MyRecipesViewModel()
        {
            Recipes = RecipeRepository.GetRecipesGroup();
        }
    }
}
