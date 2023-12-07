using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Fasad.Entities.Classes;

class Access
{
    public void AccessIsAllowed() => Console.WriteLine("Internet Access Restored");
    public void AccessIsDenied() => Console.WriteLine("Internet Access Denied");
}
