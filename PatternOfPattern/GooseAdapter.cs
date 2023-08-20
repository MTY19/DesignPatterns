using System;
namespace PatternOfPattern
{
	public class GooseAdapter : Duck
	{
        Goose goose;

        public GooseAdapter(Goose goose)
        {
            this.goose = goose;
        }

        public override void quack()
        {
            this.goose.honk();
        }

        public override void display()
        {
            Console.WriteLine("Goose Displaying");
        }
    }
}

