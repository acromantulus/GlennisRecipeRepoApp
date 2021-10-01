using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GlennisRecipeRepoApp.Models
{
    public class Feedback
    {
        #region Properties
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }
        public short Rating { get; set; }

        #endregion

        #region Constructor
        public Feedback()
        {
            
        }
        #endregion
    }
}
