using C__Abstract_Method.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Abstract_Method.Factories.Interfaces
{
    interface IFactory
    {
        IEngine createEngine();
        ITank createTank();
    }
}
