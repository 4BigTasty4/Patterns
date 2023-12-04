using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Factory_Method.Entities.Interfaces;

interface ISuv : IAutomobile
{
    public int EnginePower { get; set; }
}
