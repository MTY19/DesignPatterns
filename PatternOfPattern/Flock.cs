using System;
using System.Collections;

namespace PatternOfPattern
{
	public class Flock : Duck
	{
		List<Duck> quackers = new List<Duck>();

		public void Add(Duck duck)
		{
			quackers.Add(duck);
		}

        public override void quack()
        {
			foreach (var item in quackers)
			{
				item.quack();
			}
        }

    }
}

