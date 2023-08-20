// See https://aka.ms/new-console-template for more information
#region firstexample
using ProxyPattern.FirstExample;

ILogger logger = new BufferFileLoggerProxy(5);
logger.Log("Hello World");

#endregion
