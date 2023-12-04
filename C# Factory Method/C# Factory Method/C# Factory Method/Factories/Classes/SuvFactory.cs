using C__Factory_Method.Entities.Classes;
using C__Factory_Method.Entities.Interfaces;
using C__Factory_Method.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Factory_Method.Factories.Classes;

internal class SuvFactory : IAutomobileFactory
{
    public IAutomobile CreateAutomobile()
    {
        ISuv suv = new Suv()
        {
            Name = "Ford",
            Description = "Suv",
            EnginePower = 650
        };
        return suv;
    }
}
