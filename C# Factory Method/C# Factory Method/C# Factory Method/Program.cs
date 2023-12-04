using C__Factory_Method.Entities.Interfaces;
using C__Factory_Method.Factories.Classes;
using C__Factory_Method.Factories.Interfaces;

IAutomobileFactory automobileFactorySedan = new SedanFactory();

var sedan = automobileFactorySedan.CreateAutomobile() as ISedan;
Console.WriteLine($"Name: {sedan.Name}");
Console.WriteLine($"Description: {sedan.Description}");
Console.WriteLine($"Acceleration To One Hundred: {sedan.AccelerationToOneHundred}");
Console.WriteLine();

IAutomobileFactory automobileFactorySuv = new SuvFactory();

var suv = automobileFactorySuv.CreateAutomobile() as ISuv;
Console.WriteLine($"Name: {suv.Name}");
Console.WriteLine($"Description: {suv.Description}");
Console.WriteLine($"Engine Power: {suv.EnginePower}");
Console.WriteLine();

IAutomobileFactory automobileFactoryTruck = new TruckFactory();

var truck =  automobileFactoryTruck.CreateAutomobile() as ITruck;
Console.WriteLine($"Name: {truck.Name}");
Console.WriteLine($"Description: {truck.Description}");
Console.WriteLine($"Lifting Capacity: {truck.LiftingCapacity}");