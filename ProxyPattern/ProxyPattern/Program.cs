// See https://aka.ms/new-console-template for more information
using ProxyPattern;

Console.WriteLine("Hello, World!");
 BufferedFileLoggerProxy _proxy = new BufferedFileLoggerProxy(5);
_proxy.Log("deneme1");
_proxy.Log("deneme2");
_proxy.Log("deneme3");
_proxy.Log("deneme4");
_proxy.Log("deneme5");
_proxy.Log("deneme6");
Console.WriteLine("Finish");