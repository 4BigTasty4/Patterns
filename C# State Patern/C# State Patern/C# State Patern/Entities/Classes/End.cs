using C__State_Patern.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__State_Patern.Entities.Classes;

class End : ICheckOfMators
{
    public ICheckOfMators LoadChange()
    {
        return new End();
    }

    public string Display()
    {
        return "Check Ended";
    }
}
