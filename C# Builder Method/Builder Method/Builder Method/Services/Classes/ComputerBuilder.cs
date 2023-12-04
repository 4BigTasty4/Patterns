using Builder_Method.Entities;
using Builder_Method.Parts.Classes;
using Builder_Method.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Services.Classesl;

class ComputerBuilder : IComputerBuilder
{
    public Computer CompToBild { get; set; }

    public ComputerBuilder()
    {
        CompToBild = new Computer();
    }

    public void SetCpu(string name,string description,int gen)
    {
        CompToBild.Parts.Add(new CPU()
        {
            Name = name,
            Description = description,
            Gen = gen
        });
    }

    public void SetRam(string name,int megabytes)
    {
        CompToBild.Parts.Add(new RAM()
        {
            Name = name,
            Megabytes = megabytes
        });
    }

    public void SetVideoCard(string name,string description,int gigabytes)
    {
        CompToBild.Parts.Add(new VideoCard()
        {
            Name = name,
            Description = description,
            Gigabytes = gigabytes
        });
    }
}
