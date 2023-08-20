using System;
namespace PatternOfPattern
{
    public class Duck
	{
        IQuackable quackable;

        public Duck()
        {
        }

        public void setQuackBehaviour(IQuackable quackable)
        {
            this.quackable = quackable;
        }

        public virtual void quack()
        {
            quackable.quack();
        }

        public virtual void display()
        {
            Console.WriteLine("Duck Displaying");
        }
    }
}

