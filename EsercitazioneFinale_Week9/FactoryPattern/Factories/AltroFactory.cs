using FactoryPattern.Entities;
using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factories
{
    public class AltroFactory : ICategoryFactory
    {
        private string _name;
        private double _importo;
        private double _importoRimborsato;

        public AltroFactory(string name, double imp, double imp2)
        {
            _name = name;
            _importo = imp;
            _importoRimborsato = imp2;
        }
        public ICategory GetCategory()
        {
            return new Altro(_name, _importo, _importoRimborsato);
        }
    }
}
