using Builder_Method.Entities;
using Builder_Method.Parts.Classes;
using Builder_Method.Services.Classes;
using Builder_Method.Services.Classesl;
using Builder_Method.Services.Interfaces;

IComputerBuilder builder = new ComputerBuilder();

Director director = new Director(builder);

Computer computer = director.BuildDesignerComputer();

computer.Show();