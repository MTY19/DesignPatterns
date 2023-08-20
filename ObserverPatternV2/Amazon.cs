using System;
namespace ObserverPatternV2
{
	public class Amazon
	{
		Dictionary<IObserver,Product> observers = new();
		public Amazon()
		{
        }

		public void Register(IObserver observer,Product product)
		{
			observers.Add(observer,product);
        }

		public void UnRegister(IObserver observer)
		{
			observers.Remove(observer);
		}

		public void NotifyAll()
		{
			foreach (var item in observers)
			{
				item.Key.StockUpdate(item.Value);
            }
		}

		public void NotifyForProductName(string productName)
		{
			foreach (var item in observers)
			{
				if(item.Value.Name == productName)
				{
					item.Key.StockUpdate(item.Value);
				}
			}
		}
	}
}

