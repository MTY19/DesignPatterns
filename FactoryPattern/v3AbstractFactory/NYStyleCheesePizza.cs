using System;
namespace FactoryPattern.v3AbstractFactory
{
    public class NYStyleCheesePizza : PizzaV3
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style sauce and cheese pizza";
            dough = "Train crush dough";
            sauce = "Mariana Sauce";

            topppings.Add("Greted cheese");
        }
    }
}

