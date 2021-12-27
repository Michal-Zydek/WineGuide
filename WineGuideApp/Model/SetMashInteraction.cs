using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuide.Models
{
    [Table("set_mash_interaction")]
    public class SetMashInteraction
    {
        [Column("set_mash_interaction_id")]
        [Required]
        [Key]
        public int SetMashInteractionId { get; set; }

        [Column("set_mash_interaction_name")]
        [Required]
        public string SetMashInteractionName { get; set; }

        [Column("set_mash_interaction_type_of_quantity")]
        [Required]
        public TypeOfQuantity SetMashInteractionTypeOfQuantity { get; set; }

        [Column("set_mash_interaction_quantity")]
        [Required]
        public int SetMashInteractionQuantity { get; set; }
    }
}
