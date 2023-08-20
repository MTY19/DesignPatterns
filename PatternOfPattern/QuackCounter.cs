using System;
namespace PatternOfPattern
{
    public class QuackCounter : Duck
    {
		Duck duck;
        ISubject observable;
		static int numberOfQuack = 0;

        public QuackCounter(Duck duck)
        {
            this.duck = duck;
            observable = new Observable();
        }

        public override void quack()
        {
            duck.quack();
            numberOfQuack++;
        }

        public static int getQuacks()
        {
            return numberOfQuack;
        }

        public void registerObserver(IObserver observer)
        {
            observable.registerObserver(observer);
        }

        public void notifyObservers()
        {
            observable.notifyObservers();
        }
    }
}

