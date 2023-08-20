using System;
using System.Collections;

namespace IteratorPattern
{
	public class ContactIterator : Iterator
	{
		ArrayList arrayList;
        int position = 0;

        public ContactIterator(ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }

        public bool hasNext()
        {
            if (position >= arrayList.Count || arrayList[position] == null)
                return false;

            return true;
        }

        public Object next()
        {
            Person person = (Person)arrayList[position];
            position = position + 1;

            return person;
        }
    }
}

