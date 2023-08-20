using System;
namespace PatternOfPattern
{
    public class NormalDuck : Duck, IObserver
    {
        ISubject subject;
        Duck duck;
        public NormalDuck(ISubject subject)
        {
            setQuackBehaviour(new Quack());
            this.subject = subject;
            subject.registerObserver(this);
        }

        public override void display()
        {
            Console.WriteLine("Normal Duck Displaying ");
        }

        public void update(Duck duck)
        {
            this.duck = duck;
        }
    }
}

