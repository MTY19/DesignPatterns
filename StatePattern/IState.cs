using System;
namespace StatePattern
{
	public interface IState
	{
		void insertQuarter();
		void ejectQuarter();
		void turnCrank();
		void dispense();

	}
}

