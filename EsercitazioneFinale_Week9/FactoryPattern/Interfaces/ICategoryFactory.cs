using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Interfaces
{
    public interface ICategoryFactory
    {
        ICategory GetCategory();
    }
}
