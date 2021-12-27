using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WineGuideApp.Model;

namespace WineGuide.Models
{
    [Table("user_account")]
    public class UserAccount
    {
        [Column("account_id")]
        [Required]
        [Key]
        public int AccountId { get; set; }

        [Column("account_email")]
        [Required]
        public string AccountEmail { get; set; }

        [Column("account_name")]
        [Required]
        public string AccountName { get; set; }

        [Column("account_password")]
        [Required]
        public string AccountPassword { get; set; }


        //Connection Tabel
        public IList<UserAccount_Recipe> UserAccount_Recipes { get; set; }
    }
}
