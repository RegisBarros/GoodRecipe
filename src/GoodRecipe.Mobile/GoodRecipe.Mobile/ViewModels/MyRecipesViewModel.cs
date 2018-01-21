using GoodRecipe.Mobile.Data;
using GoodRecipe.Mobile.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace GoodRecipe.Mobile.ViewModels
{
    public class MyRecipesViewModel : BaseViewModel
    {
        static MyRecipesViewModel instance = new MyRecipesViewModel();
        public static MyRecipesViewModel Instance
        {
            get { return instance; }
            private set { instance = value; }
        }

        RecipeRepository RecipeRepository { get; set; } = new RecipeRepository();

        public List<Grouping<string, Recipe>> SourceRecipes { get; set; } = new List<Grouping<string, Recipe>>();

        public ObservableCollection<Grouping<string, Recipe>> Recipes { get; set; } = new ObservableCollection<Grouping<string, Recipe>>();

        public void Initialize()
        {
            OnNovoCMD = new Command(OnNovo);

            SourceRecipes = RecipeRepository.GetRecipesGroup();

            Filter();
        }

        private string search;
        public string Search
        {
            get { return search; }
            set
            {
                SetProperty(ref search, value);

                Filter();
            }
        }

        public void Filter()
        {
            if (search == null)
                search = "";

            List<Grouping<string, Recipe>> result;

            if (!string.IsNullOrEmpty(search))
            {
                result = SourceRecipes.Where(n => n.Select(r => r.Title.ToLowerInvariant())
                                .Contains(Search.ToLowerInvariant().Trim()))
                                .ToList();
            }
            else
            {
                result = SourceRecipes;
            }

            var remove = Recipes.Except(result).ToList();
            foreach (var item in remove)
            {
                Recipes.Remove(item);
            }

            for (int index = 0; index < result.Count; index++)
            {
                var item = result[index];
                if (index + 1 > Recipes.Count || !Recipes[index].Equals(item))
                    Recipes.Insert(index, item);
            }
        }

        public ICommand OnNovoCMD { get; private set; }
        private void OnNovo()
        {
            App.Current.MainPage.Navigation.PushAsync(
                new Views.RecipeDetailView(), true);
        }
    }
}
