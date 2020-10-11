using Microsoft.AspNetCore.Identity;
using StockApp.Models.Enums;
using StockApp.Models.Helpers;
using System;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FName { get; set; }

        [Display(Name = "Middle Name")]
        public string MName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreationDate { get; set; } = DateTime.Now.Date;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime DisabledDate { get; set; }

        public Gender Gender { get; set; }

        public string GenderName
        {
            get { return EnumNameHelper.GetDisplayName(Gender); }
        }

    }
}
