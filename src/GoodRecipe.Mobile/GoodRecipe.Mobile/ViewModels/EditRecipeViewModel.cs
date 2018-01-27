using GoodRecipe.Mobile.Commands;
using GoodRecipe.Mobile.Data;
using GoodRecipe.Mobile.Helpers;
using GoodRecipe.Mobile.Models;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GoodRecipe.Mobile.ViewModels
{
    public class EditRecipeViewModel : BaseViewModel
    {
        private Recipe recipe;
        public Recipe Recipe
        {
            get { return recipe; }
            set { SetProperty(ref recipe, value); }
        }

        private ImageSource _imageSource;
        public ImageSource ImageSource
        {
            get { return _imageSource; }
            set { SetProperty(ref _imageSource, value); }
        }

        public IEnumerable<Category> Categories { get; private set; }

        public CategoryRepository CategoryRepository { get; private set; } = new CategoryRepository();

        public List<string> MealsType => MealType.GetMealsType();

        #region Commands
        public RegisterRecipeCommand RegisterRecipeCommand => new RegisterRecipeCommand(this);

        public ICommand CancelRegisterCommand => new Command(async () => await Cancel());

        public ICommand PickPictureCommand => new Command(async () => await PickPicture());

        public ICommand TakePhotoPictureCommand => new Command(async () => await TakePhotoPicture());
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

        public async Task PickPicture()
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
                return;

            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            ImageSource = ImageSource.FromStream(() => file.GetStream());

            Stream streamFile = file.GetStream();
            Recipe.PictureStream = streamFile.ToByteArray();
        }

        public async Task TakePhotoPicture()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                return;

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions() { });

            if (file == null)
                return;

            ImageSource = ImageSource.FromStream(() => file.GetStream());

            Stream streamFile = file.GetStream();
            Recipe.PictureStream = streamFile.ToByteArray();
        }
    }
}
