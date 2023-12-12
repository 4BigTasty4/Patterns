using C__State_Patern.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C__State_Patern.Entities.Classes;

class Start : ICheckOfMators
{
    public ICheckOfMators LoadChange()
    {
        return new LowSpeed();
    }
    public string Display()
    {
        return "The Check Has Begun";
    }
}
