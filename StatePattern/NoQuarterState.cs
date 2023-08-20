using System;
namespace StatePattern
{
	public class NoQuarterState : IState
	{
        GumballMachine gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You havent inserted a quarter");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Quarter inserted");
            gumballMachine.setState(gumballMachine.getHasQuarterState());

        }

        public void turnCrank()
        {
            Console.WriteLine("You turned but there is no quarter");
        }
    }
}

