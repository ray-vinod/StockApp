using System;

namespace StockApp.Services
{
    public class IssueListPageRefreshService
    {
        public event Action OnRefreshRequested;

        public void CallRefreshPage()
        {
            OnRefreshRequested?.Invoke();
        }
    }
}
