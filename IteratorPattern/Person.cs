using System;
namespace IteratorPattern
{
	public class Person 
	{
		private string Name;
        private int Age;
        private long Tckno;
        
        public Person(string name, int age, long tckno)
        {
            Name = name;
            Age = age;
            Tckno = tckno;
        }

        public string getName()
        {
            return Name;
        }

        public int getAge()
        {
            return Age;
        }


        public long getTckno()
        {
            return Tckno;
        }
    }
}

