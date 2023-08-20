using System;
namespace ObserverPatternV2
{
    public interface IObserver
    {
        void StockUpdate(Product product);
    }
}

