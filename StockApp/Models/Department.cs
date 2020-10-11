using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models
{
    public class Department
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "Department")]
        public string Name { get; set; }

        //Navigation
        //One to Many
        public virtual List<Doctor> Doctors { get; set; }
    }
}
