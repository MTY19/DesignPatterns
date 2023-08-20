using System;
namespace ObserverPatternV2
{
	public class MehmetObserver : IObserver
	{
        public Product product;

        public MehmetObserver(Product product)
        {
            this.product = product;
        }

        public void StockUpdate(Product product)
        {
            Console.WriteLine($"Mehmet observed  {product.Name} in stock now!");
        }
    }
}

