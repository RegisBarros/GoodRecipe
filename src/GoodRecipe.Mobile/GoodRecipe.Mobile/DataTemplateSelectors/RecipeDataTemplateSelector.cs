using GoodRecipe.Mobile.Models;
using GoodRecipe.Mobile.ViewCells;
using Xamarin.Forms;

namespace GoodRecipe.Mobile.DataTemplateSelectors
{
    public class RecipeDataTemplateSelector : DataTemplateSelector
    {
        DataTemplate recipeTemplate;

        public RecipeDataTemplateSelector()
        {
            recipeTemplate = new DataTemplate(typeof(RecipeCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = item as Recipe;

            if (recipe == null)
                return null;

            return recipeTemplate;
        }
    }
}
