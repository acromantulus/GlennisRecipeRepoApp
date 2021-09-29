using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlennisRecipeRepoApp.Models
{
    public class Recipe
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Instructions { get; set; }
        public string ImagePath { get; set; }
        #endregion

        #region Constructor
        public Recipe()
        {

        }
        #endregion
    }
}
