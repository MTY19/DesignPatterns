using System;
namespace FactoryPattern
{
	public interface IPizza
	{
		void prepare();
		void cut();
		void box();
		void bake();
	}
}

