using System;
using System.Collections;

namespace IteratorPattern
{
	public class Customer : IPerson
	{
        public static int MAX_ITEMS = 6;
        public int numberOfPeople = 0;
        Person[] people;

        public Customer(Person[] people)
        {
            this.people = people;
        }

        public void addItem(Person person)
        {
            people[numberOfPeople] = person;
            numberOfPeople++;
        }

        public Iterator createPerson()
        {
            return new CustomerIterator(people);
        }
    }
}

