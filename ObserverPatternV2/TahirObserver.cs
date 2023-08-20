using System;
namespace ObserverPatternV2
{
    public class TahirObserver : IObserver
    {
        public string FullName { get; set; }
      

        public TahirObserver(String fullName)
        {
            this.FullName = fullName;
        }

        public void StockUpdate(Product product)
        {
            Console.WriteLine($"{FullName}, Tahir observed  {product.Name} in stock now!");
        }

    }
}

