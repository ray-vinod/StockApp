using System;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models
{
    public class Recieve : BaseTable
    {
        public Recieve()
        {
        }
        //public Guid Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [Display(Name = "Mfg. Date")]
        public DateTime MfgDate { get; set; } = DateTime.Now.Date;
        
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Expiry Date")]
        public DateTime ExpDate { get; set; } = DateTime.Now.Date;

        [DataType(DataType.Date)]
        
        [Display(Name = "Recieve Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RecieveDate { get; set; } = DateTime.Now.Date;

        [Display(Name = "Recieved By")]
        [Required]
        public string RecievedBy { get; set; }

        [Required]
        public int Qty { get; set; } = 0;

        public int UpdatedQty { get; set; } = 0;

        public bool IsUsed { get; set; } = false;


        //Navigation property
        //many-to-one
        public Guid ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
