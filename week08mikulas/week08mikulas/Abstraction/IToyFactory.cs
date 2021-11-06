using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week08mikulas.Abstraction
{
    public interface IToyFactory
    {
        IToyFactory CreateNew();
    }
}
