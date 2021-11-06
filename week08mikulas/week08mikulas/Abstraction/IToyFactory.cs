using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08mikulas.Entities;

namespace week08mikulas.Abstraction
{
    public interface IToyFactory
    {
        Toy CreateNew();
    }
}
