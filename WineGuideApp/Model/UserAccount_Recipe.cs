using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WineGuide.Models;

namespace WineGuideApp.Model
{
    public class UserAccount_Recipe
    {
        public int UserAccountId { get; set; }
        public UserAccount UserAccount { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
