using System.IO;

namespace GoodRecipe.Mobile.Models
{
    public class Recipe : BaseModel
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }


        public string Description { get; set; }

        public int ReadyInTime { get; set; }

        public int NumberOfServings { get; set; }

        public string MealType { get; set; }

        public string Ingredients { get; set; }

        public string Directions { get; set; }

        public string Picture { get; set; }

        private byte[] _pictureStream;

        public byte[] PictureStream
        {
            get { return _pictureStream; }
            set { SetProperty(ref _pictureStream, value); }
        }

        public bool IsRecommended { get; set; }

        public Category Category { get; set; }

        public string TitleSort
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Title) || Title.Length == 0)
                    return "?";

                return Title[0].ToString().ToUpper();
            }
        }
    }
}
