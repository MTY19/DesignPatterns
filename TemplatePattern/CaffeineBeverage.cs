using System;
namespace TemplatePattern
{
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boil();
            brew();
            pourInCup();
            if (customerWantCondiments())
                addCondiments();
        }

        public abstract void addCondiments();

        public abstract void brew();

        public void boil()
        {
            Console.WriteLine("Boiling ...");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pour into cup");
        }

        public virtual bool customerWantCondiments()
        {
            return true;
        }
    }
}

