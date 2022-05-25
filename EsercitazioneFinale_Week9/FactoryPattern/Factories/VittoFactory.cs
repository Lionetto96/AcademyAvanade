using FactoryPattern.Entities;
using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factories
{
    public class VittoFactory :ICategoryFactory
    {
        private string _name;
        private double _importo;
        private double _importoRimborsato;

        public VittoFactory(string name, double imp, double imp2)
        {
            _name = name;
            _importo = imp;
            _importoRimborsato = imp2;
        }
        public ICategory GetCategory()
        {
            return new Vitto(_name, _importo, _importoRimborsato);
        }
    }
}
