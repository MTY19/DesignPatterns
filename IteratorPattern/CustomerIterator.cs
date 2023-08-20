using System;
using System.Collections;

namespace IteratorPattern
{
	public class CustomerIterator : Iterator
	{
        Person[] persons;
        int position = 0;

        public CustomerIterator(Person[] persons)
        {
            this.persons = persons;
        }

        public bool hasNext()
        {
            if (position >= persons.Length || persons[position] == null)
                return false;

            return true;
        }

        public Object next()
        {
            Person person = persons[position];
            position = position + 1;
            return person;
        }
    }
}

