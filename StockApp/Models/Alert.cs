using StockApp.Models.Enums;

namespace StockApp.Models
{

    public class Alert
    {
        public Alert() { }

        public Alert(string msg, AlertType alertType)
        {
            Message = msg;
            AlertType = alertType;
        }

        public string Message { get; set; }
        public AlertType AlertType { get; set; }

    }
}
