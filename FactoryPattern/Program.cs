// See https://aka.ms/new-console-template for more information
using FactoryPattern.v1;
using FactoryPattern.v3AbstractFactory;
using FactoryPattern.v4AbstractFactory;

Console.WriteLine("Hello, World!");

PizzaV1 pizzaV1 = new PizzaV1();

var pizza1 = pizzaV1.orderPizza("Italiano");
Console.WriteLine(pizza1.GetType().ToString());

PizzaStore nyPizzaStore = new NYPizzaStore();
PizzaV3 pizzaNY = nyPizzaStore.orderPizza("Turkish");
Console.WriteLine("Tahir ordered a " + pizzaNY.getName());


PizzaStore trPizzaStore = new TRPizzaStore();
PizzaV3 pizzaTR = trPizzaStore.orderPizza("Turkish");
Console.WriteLine("Mehmet ordered a " + pizzaTR.getName());

PizzaStoreV4 pizzaStoreV4 = new NYPizzaStoreV4();
PizzaV4 pizzaV4  = pizzaStoreV4.orderPizza("Cheese");
Console.WriteLine("Yusuf ordered a " + pizzaV4.getName());











