using GoodRecipe.Mobile.Models;
using GoodRecipe.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace GoodRecipe.Mobile.Commands
{
    public class RegisterRecipeCommand : ICommand
    {
        private EditRecipeViewModel _viewModel;
        public RegisterRecipeCommand(EditRecipeViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Register(parameter as Recipe);
        }
    }
}
