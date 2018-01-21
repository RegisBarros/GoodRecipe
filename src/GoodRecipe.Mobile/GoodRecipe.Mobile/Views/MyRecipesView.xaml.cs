using GoodRecipe.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodRecipe.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyRecipesView : ContentPage
	{
        public MyRecipesViewModel ViewModel { get; set; }

        public MyRecipesView ()
		{
			InitializeComponent ();

            ViewModel = new MyRecipesViewModel();

            BindingContext = ViewModel;
		}
	}
}