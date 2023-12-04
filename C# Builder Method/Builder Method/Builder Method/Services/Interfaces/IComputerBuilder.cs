using Builder_Method.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Services.Interfaces;

interface IComputerBuilder
{
    public Computer CompToBild { get; set; }
    public void SetCpu(string name, string description, int gen);
    public void SetRam(string name, int megabytes);
    public void SetVideoCard(string name, string description, int gigabytes);
}
