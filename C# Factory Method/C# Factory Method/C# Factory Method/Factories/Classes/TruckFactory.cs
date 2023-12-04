using C__Factory_Method.Entities.Classes;
using C__Factory_Method.Entities.Interfaces;
using C__Factory_Method.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Factory_Method.Factories.Classes;

internal class TruckFactory : IAutomobileFactory
{
    public IAutomobile CreateAutomobile()
    {
        ITruck truck = new Truck()
        {
            Name = "Ford",
            Description = "Truck",
            LiftingCapacity = 1000
        };
        return truck;
    }
}
