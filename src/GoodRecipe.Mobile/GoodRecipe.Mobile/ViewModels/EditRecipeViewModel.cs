using GoodRecipe.Mobile.Commands;
using GoodRecipe.Mobile.Data;
using GoodRecipe.Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GoodRecipe.Mobile.ViewModels
{
    public class EditRecipeViewModel : BaseViewModel
    {
        static EditRecipeViewModel instancia = new EditRecipeViewModel();
        public static EditRecipeViewModel Instancia
        {
            get { return instancia; }
            private set { instancia = value; }
        }

        private Recipe recipe;
        public Recipe Recipe
        {
            get { return recipe; }
            set { SetProperty(ref recipe, value); }
        }

        public IEnumerable<Category> Categories { get; private set; }

        public CategoryRepository CategoryRepository { get; private set; } = new CategoryRepository();

        public List<string> MealsType => MealType.GetMealsType();

        #region Commands
        public RegisterRecipeCommand RegisterRecipeCommand => new RegisterRecipeCommand(this);

        public ICommand CancelRegisterCommand => new Command(async () => await Cancel()); 
        #endregion

        public EditRecipeViewModel()
        {
            Categories = CategoryRepository.GetAll();

            Recipe = new Recipe();
        }

        public void Register(Recipe recipe)
        {
            // save
        }

        public async Task Cancel()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
