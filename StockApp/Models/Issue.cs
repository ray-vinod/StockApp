using System;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models
{
    public class Issue : BaseTable
    {
        //public Guid Id { get; set; }
        //public string ProductName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]

        [Display(Name = "Issue Date")]
        public DateTime IssueDate { get; set; } = DateTime.Now.Date;

        [Required]
        public int Qty { get; set; }

        [Display(Name = "Issued By")]
        [Required]
        public string IssuedBy { get; set; } //User Name

        public string Remarks { get; set; }//Issue for like patient/ or ot use


        //Navigation property
        //many-to-one
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
