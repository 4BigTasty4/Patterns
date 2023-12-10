using C__Proxy_Method.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Proxy_Method.Entities.Classes;

class Factory : IFactory
{
    public string GetOrder(int num) => "Order number: " +  num;
}
