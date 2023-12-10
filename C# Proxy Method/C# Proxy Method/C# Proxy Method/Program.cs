using C__Proxy_Method.Entities;
using C__Proxy_Method.Entities.Classes;
using C__Proxy_Method.Entities.Interfaces;

IFactory factory = new OrderRequest(new Factory());

Console.WriteLine(factory.GetOrder(1));
Console.WriteLine(factory.GetOrder(2));
Console.WriteLine(factory.GetOrder(3));
Console.WriteLine(factory.GetOrder(1));