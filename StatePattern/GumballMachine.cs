using System;
namespace StatePattern
{
	public class GumballMachine
	{
		IState soldOutState;
        IState noQuarterState;
        IState hasQuarterState;
        IState soldState;

        IState state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {

            this.soldOutState = new SoldOutState(this);
            this.noQuarterState = new NoQuarterState(this);
            this.hasQuarterState = new HasQuarterState(this);
            this.soldState = new SoldState(this);
            this.count = numberGumballs;
            state = soldOutState;
            if(numberGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(IState state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot... ");
            if(count != 0)
            {
                count = count - 1;
            }
        }

        public IState getNoQuarterState()
        {
            return noQuarterState;
        }

        public IState getSoldState()
        {
            return soldState;
        }

        public IState getSoldOutState()
        {
            return soldOutState;
        }

        public IState getHasQuarterState()
        {
            return hasQuarterState;
        }

        public int getCount()
        {
            return count;
        }
    }
}

