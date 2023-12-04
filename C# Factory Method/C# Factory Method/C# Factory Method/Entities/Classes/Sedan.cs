using C__Factory_Method.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Factory_Method.Entities.Classes;

class Sedan : ISedan
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int AccelerationToOneHundred { get; set; }
}
