using Builder_Method.Parts.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Entities;

class Computer
{
    public List<IPart> Parts { get; set; }

    public Computer()
    {
        Parts = new List<IPart>();
    }

    public void AddPart(IPart part)
    {
        Parts.Add(part);
    }

    public void Show()
    {
        Console.WriteLine("Computer Parts: ");
        foreach (var part in Parts)
        {
            Console.WriteLine(part);
            
        }
    }
}
