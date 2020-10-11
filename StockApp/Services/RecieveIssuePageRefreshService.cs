using System;

namespace StockApp.Services
{
    public class RecieveIssuePageRefreshService
    {
        public event Action OnRefreshRequested;

        public void CallRefreshPage()
        {
            OnRefreshRequested?.Invoke();
        }
    }
}
