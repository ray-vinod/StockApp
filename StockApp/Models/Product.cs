using StockApp.Models.Enums;
using StockApp.Models.Helpers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StockApp.Models
{
    public class Product : BaseTable
    {
        public Product()
        {
        }

        [Required]
        public string Name { get; set; }

        public Group Group { get; set; }

        public string GroupName
        {
            get { return EnumNameHelper.GetDisplayName(Group); }
        }

        //Navigation property
        //one-to-many
        public virtual List<Recieve> Recieve { get; set; }
        public virtual List<Issue> Issue { get; set; }

        public int ProductPrefixId { get; set; }
        public virtual ProductPrefix ProductPrefix { get; set; }
        public int ProductSuffixId { get; set; }
        public virtual ProductSuffix ProductSufix { get; set; }


    }
}
