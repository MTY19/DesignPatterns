using System;
namespace PatternOfPattern
{
	public class MallardDuck : Duck, IObserver
    {
        ISubject subject;
        Duck duck;
        public MallardDuck(ISubject subject)
        {
            setQuackBehaviour(new Squack());
            this.subject = subject;
            subject.registerObserver(this);
        }

        public override void display()
        {
            Console.WriteLine("Mallard Duck Displaying");
        }

        public void update(Duck duck)
        {
            Console.WriteLine("Tak tak mallard");
            this.duck = duck;
        }
    }
}

