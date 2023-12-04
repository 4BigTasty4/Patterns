using C__Abstract_Method.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Abstract_Method.Entities.Classes.Engine;

class LightTankEngine : IEngine
{
    public void EngineCraft() => Console.WriteLine("With A Light Tank Engine");
}
