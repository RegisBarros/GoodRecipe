using GoodRecipe.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodRecipe.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditRecipeView : ContentPage
	{
        public EditRecipeViewModel ViewModel { get; set; }

        public EditRecipeView ()
		{
			InitializeComponent ();

            BindingContext = EditRecipeViewModel.Instancia;
		}
	}
}