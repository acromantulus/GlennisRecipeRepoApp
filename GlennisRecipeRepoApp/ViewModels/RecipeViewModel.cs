using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GlennisRecipeRepoApp.ViewModels
{
    public class RecipeViewModel
    {
        #region Properties
        public string Title { get; set; }
        public string Instructions { get; set; }
        [BindProperty]
        public IFormFile ImagePath { get; set; }
        #endregion
    }
}
