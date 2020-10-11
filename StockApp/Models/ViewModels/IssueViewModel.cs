using System;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models.ViewModels
{
    public class IssueViewModel
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, ConvertEmptyStringToNull = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Issue Date")]
        public DateTime IssueDate { get; set; } = DateTime.Now.Date;

        [Required]
        public int Qty { get; set; }

        public int AvQty { get; set; }

        public string Remarks { get; set; }

        public Guid PId { get; set; }

        //For the searching purpose
        [Required]
        public Product SelectedProduct { get; set; }


    }
}
