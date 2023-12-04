using Builder_Method.Parts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Parts.Classes;

class CPU : IPart
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Gen { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Description: {Description}, Gen: {Gen}";
    }
}
