using System;

namespace StockApp.Models
{
    public class BaseTable
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
