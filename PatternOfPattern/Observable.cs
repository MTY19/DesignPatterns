using System;
namespace PatternOfPattern
{
    public class Observable : ISubject
    {
        List<IObserver> observerList;

        public Observable()
		{
            observerList = new List<IObserver>();
        }

        public virtual void notifyObservers()
        {
            foreach (var item in observerList)
            {
                item.update(new Duck());
            }
        }

        public virtual void registerObserver(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observerList.Remove(observer);
        }
    }
}

