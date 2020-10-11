using StockApp.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models.ViewModels
{
    public class RecieveViewModel
    {
        public Guid Id { get; set; }
        public Group Group { get; set; }

        [Required]
        [Display(Name = "Item Name")]
        public string ProductName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
            ConvertEmptyStringToNull = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Mfg. Date")]
        public DateTime MfgDate { get; set; } = DateTime.Now.Date;

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
            ConvertEmptyStringToNull = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Expiry Date")]
        public DateTime ExpDate { get; set; } = DateTime.Now.Date;

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
            ConvertEmptyStringToNull = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Recieve Date")]
        public DateTime RecieveDate { get; set; } = DateTime.Now.Date.AddTicks(12);

        [Required]
        [Display(Name = "Quantity")]
        public int Qty { get; set; } = 0;

        public int DayToExp { get; set; }

        public string RecievedBy { get; set; }

        //for the searching purpose into the form
        [Required]
        public Product SelectedProduct { get; set; }
    }
}
