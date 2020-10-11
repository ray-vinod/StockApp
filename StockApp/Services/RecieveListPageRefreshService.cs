using System;

namespace StockApp.Services
{
    public class RecieveListPageRefreshService
    {
        public event Action OnRefreshRequested;

        public void CallRefreshPage()
        {
            OnRefreshRequested?.Invoke();
        }
    }
}
