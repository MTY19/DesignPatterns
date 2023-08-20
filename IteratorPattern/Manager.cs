using System;
namespace IteratorPattern
{
	public class Manager
	{
		Contact contact;
		Customer customer;

        public Manager(Contact contact, Customer customer)
        {
            this.contact = contact;
            this.customer = customer;
        }

        public void printPersons()
        {
            Iterator contactIterator = contact.createPerson();
            Iterator customerIterator = customer.createPerson();

            printPersons(customerIterator);
            printPersons(contactIterator);
        }

        private void printPersons(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                Person person = (Person)iterator.next();
                Console.WriteLine(person.getName());
                Console.WriteLine(person.getTckno());
                Console.WriteLine(person.getAge());
            }
        }
    }
}

