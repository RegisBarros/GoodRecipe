using GoodRecipe.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoodRecipe.Mobile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CatalogView : ContentPage
	{
        public CatalogViewModel ViewModel { get; set; }

        public CatalogView ()
		{
			InitializeComponent ();

            ViewModel = CatalogViewModel.Instance;

            BindingContext = ViewModel;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            lstRecipes.IsRefreshing = !lstRecipes.IsRefreshing;
            CatalogViewModel.Instance.Initialize();
            lstRecipes.IsRefreshing = !lstRecipes.IsRefreshing;
        }
    }
}