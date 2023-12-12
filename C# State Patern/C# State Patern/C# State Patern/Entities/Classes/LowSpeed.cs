using C__State_Patern.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__State_Patern.Entities.Classes;

class LowSpeed : ICheckOfMators
{
    public ICheckOfMators LoadChange()
    {
        return new AverageSpeed();
    }

    public string Display()
    {
        return "Motor running at low speed";
    }
}
