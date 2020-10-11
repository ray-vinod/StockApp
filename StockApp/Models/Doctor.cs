using System;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models
{
    public class Doctor
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }

        //Navigation
        //many to one relationship 
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
