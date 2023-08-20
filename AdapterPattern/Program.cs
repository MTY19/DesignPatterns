// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");

TurkeyObjectAdapter adapter = new TurkeyObjectAdapter();
adapter.fly();
adapter.swim();

