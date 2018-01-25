using GoodRecipe.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodRecipe.Mobile.Data
{
    public class CategoryRepository
    {
        public IEnumerable<Category> GetAll()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Title = "Carnes"
                },
                new Category()
                {
                    Title = "Molhos e Saladas"
                },
                new Category()
                {
                    Title = "Lanches"
                },
                new Category()
                {
                    Title = "Massas"
                },
            };
        }
    }
}
