using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeFriendslist.Models
{
    public class Friend
    {
        [Key]
        [Display(Name = "Type Id: ")]
        [Required]
        public int id { get; set; }

        [Display(Name = "Type Name: ")]
        [Required(ErrorMessage = "The name must not be empty.")]
        public string name { get; set; }

        [Display(Name = "Type Location of friend: ")]
        [StringLength(25, ErrorMessage = "This is a required field, add a maximum of 25 characters.")]
        public string place { get; set; }

        [Display(Name = "Age: ")]
        [Required]
        public int age { get; set; }

        [Display(Name = "Occupation: ")]
        [Required]
        public string occupation { get; set; }

        [Display(Name = "Favorite Sport: ")]
        [Required]
        public string favoriteSport { get; set; }
    }
}
