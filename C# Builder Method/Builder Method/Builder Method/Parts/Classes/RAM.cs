using Builder_Method.Parts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Parts.Classes;

class RAM : IPart
{
    public string Name { get; set; }
    public int Megabytes { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Megabytes: {Megabytes}";
    }
}
