using C__Factory_Method.Entities.Classes;
using C__Factory_Method.Entities.Interfaces;
using C__Factory_Method.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Factory_Method.Factories.Classes;

internal class SedanFactory : IAutomobileFactory
{
    public IAutomobile CreateAutomobile()
    {
        ISedan sedan = new Sedan()
        {
            Name = "Porshe",
            Description = "Sedan",
            AccelerationToOneHundred = 3
        };
        return sedan;
    }
}
