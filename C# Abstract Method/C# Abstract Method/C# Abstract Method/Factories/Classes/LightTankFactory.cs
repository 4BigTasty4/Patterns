using C__Abstract_Method.Entities.Classes.Engine;
using C__Abstract_Method.Entities.Classes.Tank;
using C__Abstract_Method.Entities.Interfaces;
using C__Abstract_Method.Factories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Abstract_Method.Factories.Classes; 

interface LightTankFactory : IFactory
{
    public ITank createTank() => new LightTank();
    public IEngine createEngine() => new LightTankEngine();
}
