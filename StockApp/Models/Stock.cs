namespace StockApp.Models
{
    public class Stock : BaseTable
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        //public Guid StockId { get; set; }
        public string ProductName { get; set; }
        public int TotalRecieve { get; set; }
        public int TotalIssue { get; set; }
        public int InStock { get; set; }
    }
}
