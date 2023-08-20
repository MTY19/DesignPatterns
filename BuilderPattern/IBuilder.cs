using System;
namespace BuilderPattern
{
	public interface IBuilder
	{
		IBuilder Append(string text);
        IBuilder AppendParam(string name,string value);
    }
}

