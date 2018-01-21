﻿using GoodRecipe.Mobile.ViewModels;
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

            ViewModel = MyRecipesViewModel.Instance;

            BindingContext = ViewModel;
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            lstRecipes.IsRefreshing = !lstRecipes.IsRefreshing;
            MyRecipesViewModel.Instance.Initialize();
            lstRecipes.IsRefreshing = !lstRecipes.IsRefreshing;
        }
    }
}