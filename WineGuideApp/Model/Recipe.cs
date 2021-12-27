using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WineGuideApp.Model;

namespace WineGuide.Models
{
    [Table("recipe")]
    public class Recipe
    {
        [Column("recipe_id")]
        [Required]
        [Key]
        public int RecipeId { get; set; }

        [Column("recipe_name")]
        [Required]
        public string RecipeName { get; set; }

        [Column("recipe_type_alcohol")]
        [Required]
        public TypeAlcohol RecipeTypeAlcohol { get; set; }


        //Connection Tabel
        public List<UserAccount_Recipe> UserAccount_Recipes { get; set; }
        
        public List<RecipeIngredients> RecipeIngredients { get; set; }

        public List<SetMash> SetMashes { get; set; }
    }

    public enum TypeAlcohol
    {
        WINE,
        BEER,
        WHISKY
    }

}
