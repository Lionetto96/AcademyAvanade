using FactoryPattern.Entities;
using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factories
{
    public class AlloggioFactory : ICategoryFactory
    {
        public string _name;
        public double _importo;
        public double _importoRimborsato;

        public AlloggioFactory(string name,double imp,double imp2)
        {
            _name = name;
            _importo = imp;
            _importoRimborsato = imp2;
        }
        public ICategory GetCategory()
        {
            return new Alloggio(_name, _importo, _importoRimborsato);
        }
    }
}
