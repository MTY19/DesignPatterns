// See https://aka.ms/new-console-template for more information
using System.Collections;
using IteratorPattern;

Console.WriteLine("Hello, World!");

Contact contact = new Contact(new ArrayList());
Customer customer = new Customer(new Person[Customer.MAX_ITEMS]);

contact.addItem(new Person("Tahir", 19, 1234432233));
contact.addItem(new Person("Yusuf", 1, 4234433234));
contact.addItem(new Person("Zeren", 25, 4222112344));

customer.addItem(new Person("Mehmet", 30, 14414244234));
customer.addItem(new Person("Tahir", 29, 98244222334));
customer.addItem(new Person("Yıldırım", 28, 8798773333));
Manager manager = new Manager(contact, customer);
manager.printPersons();


