using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuide.Models
{
    [Table("set_mash")]
    public class SetMash
    {
        [Column("set_mash_id")]
        [Required]
        [Key]
        public int SetMashId { get; set; }

        [Column("set_mash_start")]
        [Required]
        public DateTime SetMashStart { get; set; }

    }
}
