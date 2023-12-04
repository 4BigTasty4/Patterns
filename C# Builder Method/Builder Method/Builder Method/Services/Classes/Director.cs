using Builder_Method.Entities;
using Builder_Method.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Services.Classes;

class Director
{
    private readonly IComputerBuilder builder;

    public Director(IComputerBuilder builder)
    {
        this.builder = builder;
    }

    public Computer BuildOfficeComputer()
    {
        builder.SetCpu("Intel", "I3", 3);
        builder.SetRam("HP", 4);
        builder.SetVideoCard("Intel", "Graphiks 1000", 1);

        return builder.CompToBild;
    }

    public Computer BuildGamingComputer()
    {
        builder.SetCpu("Intel", "I7", 7);
        builder.SetRam("Kingston", 16);
        builder.SetVideoCard("Nvidia", "RTX 4090",8);

        return builder.CompToBild;
    }

    public Computer BuildDesignerComputer()
    {
        builder.SetCpu("Intel", "I9", 12);
        builder.SetRam("Kingston", 32);
        builder.SetVideoCard("Nvidia", "RTX 4090", 8);

        return builder.CompToBild;
    }
}
