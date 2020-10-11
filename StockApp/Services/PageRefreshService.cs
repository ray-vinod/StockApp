using System;

namespace StockApp.Services
{
    public class PageRefreshService
    {
        public event Action OnRefreshRequested;

        public void CallRefreshPage()
        {
            OnRefreshRequested?.Invoke();
        }
    }
}
