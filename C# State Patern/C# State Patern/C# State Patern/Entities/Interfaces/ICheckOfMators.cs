using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__State_Patern.Entities.Interfaces;

interface ICheckOfMators
{
    ICheckOfMators LoadChange();
    string Display();
}
