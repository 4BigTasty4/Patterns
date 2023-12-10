using C__Proxy_Method.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Proxy_Method.Entities;

class OrderRequest : IFactory
{
    private IFactory factory;
    private Dictionary<int, string> cache;

    public OrderRequest(IFactory factory)
    {
        this.factory = factory;
        cache = new Dictionary<int, string>();
    }

    public string GetOrder(int num)
    {
        string order;
        if (cache.ContainsKey(num))
        {
            order = cache[num];
            order = "From Orders: " + order;
        }
        else
        {
            order = factory.GetOrder(num);
            cache.Add(num, order);
        }
        return order;
    }
}
