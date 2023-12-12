using C__State_Patern.Entities.Classes;
using C__State_Patern.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__State_Patern.Entities;

class Motor
{
    private ICheckOfMators _checkOfMators;

    public Motor()
    {
        _checkOfMators = new Start();
    }

    public void LoadChange()
    {
        _checkOfMators = _checkOfMators.LoadChange();
    }

    public string Display()
    {
        return $"Motor condition: {_checkOfMators.Display()}";
    }
}
