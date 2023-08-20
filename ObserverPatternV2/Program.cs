// See https://aka.ms/new-console-template for more information
using ObserverPatternV2;

Console.WriteLine("Hello, World!");

Product product = new Product("IPhone 14 pro max",44799);
Product product2 = new Product("Samsung S23", 24433);

Amazon amazon = new Amazon();
TahirObserver tahirObserver = new TahirObserver("Yeni telefon geldi");
MehmetObserver mehmetObserver = new MehmetObserver(product);
amazon.Register(tahirObserver,product);
amazon.Register(mehmetObserver, product2);

amazon.NotifyForProductName("Samsung S23");
amazon.NotifyAll();



