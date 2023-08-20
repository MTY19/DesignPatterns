// See https://aka.ms/new-console-template for more information
using PatternOfPattern;
AbstractDuckFactory abstractDuckFactory = new DuckFactory();

Duck duck1 = abstractDuckFactory.CreateMallardDuck();
duck1.quack();
duck1.display();

Duck duck2 = abstractDuckFactory.CreateNormalDuck();
duck2.quack();
duck2.display();

Duck duck3 = new GooseAdapter(new Goose());
duck3.quack();
duck3.display();

Flock flock = new Flock();

flock.Add(duck1);
flock.Add(duck2);
flock.Add(duck3);

flock.quack();
flock.notifyObservers();

Console.WriteLine(QuackCounter.getQuacks() + " times quacked");