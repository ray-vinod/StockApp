using StockApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.Models.ViewModels
{
    public class StockViewModel
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public Group Group { get; set; }
        public int TotalRecieve { get; set; }
        public int TotalIssue { get; set; }
        public int InStock { get; set; }
        public int TotalExpired { get; set; }
    }
}
