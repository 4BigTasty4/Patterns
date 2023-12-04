using C__Abstract_Method.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Abstract_Method.Entities.Classes.Tank;

class HeavyTank : ITank
{
    public void TankCraft(IEngine engine)
    {
        Console.Write("Crafting Heavy Tank: ");
        engine.EngineCraft();
    }
}
