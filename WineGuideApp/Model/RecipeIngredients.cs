using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuide.Models
{
    [Table("recipe_ingredients")]
    public class RecipeIngredients
    {
        [Column("recipe_ingredients_id")]
        [Required]
        [Key]
        public int RecipeIngredientsId { get; set; }

        [Column("recipe_ingredients_name")]
        [Required]
        public string RecipeIngredientsName { get; set; }

        [Column("recipe_ingredients_type_of_quantity")]
        [Required]
        public TypeOfQuantity RecipeIngredientsTypeOfQuantity { get; set; }

        [Column("recipe_ingredients_quantity")]
        [Required]
        public int RecipeIngredientsQuantity { get; set; }


        //Connection Tabel
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }


    public enum TypeOfQuantity
    {
        Liter,
        KG
    }
}
