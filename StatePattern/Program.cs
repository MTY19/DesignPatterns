﻿// See https://aka.ms/new-console-template for more information

using StatePattern;

GumballMachine gumballMachine = new GumballMachine(5);
Console.WriteLine(gumballMachine);

gumballMachine.insertQuarter();
gumballMachine.turnCrank();

Console.WriteLine(gumballMachine);

gumballMachine.insertQuarter();
gumballMachine.turnCrank();
gumballMachine.insertQuarter();
gumballMachine.turnCrank();

Console.WriteLine(gumballMachine);


