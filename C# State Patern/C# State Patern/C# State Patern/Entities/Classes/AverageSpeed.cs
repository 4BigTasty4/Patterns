using C__State_Patern.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__State_Patern.Entities.Classes;

class AverageSpeed : ICheckOfMators
{
    public ICheckOfMators LoadChange()
    {
        return new MaximumSpeed();
    }

    public string Display()
    {
        return "Motor runs at medium speed";
    }
}
