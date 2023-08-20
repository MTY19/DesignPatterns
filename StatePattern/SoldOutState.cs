using System;
namespace StatePattern
{
	public class SoldOutState : IState
    {
        GumballMachine gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You cant insert a quarter, the machine is sold out");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You cant insert a quarter, the machine is sold out");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned but there are no gumballs");
        }
    }
}


