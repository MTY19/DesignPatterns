using System;
using System.Collections;

namespace IteratorPattern
{
	public class Contact : IPerson
	{
        ArrayList people;

        public Contact(ArrayList people)
        {
            this.people = people;
        }

        public void addItem(Person person)
        {
            people.Add(person);
        }

        public Iterator createPerson()
        {
            return new ContactIterator(people);
        }
    }
}

