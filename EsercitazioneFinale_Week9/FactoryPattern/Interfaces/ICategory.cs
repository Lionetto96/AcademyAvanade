using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Interfaces
{
    public interface ICategory
    {
        string Name { get;  }
        double Importo { get; set; }
        double ImportoRimborsato { get; set; }
    }
}
