using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Entities
{
    internal class Altro :ICategory
    {
        public string Name { get; }
        public double Importo { get; set; }
        public double ImportoRimborsato { get; set; }
        public double GetImportoRimborsato()
        {
            double ImportoRimborsato;
            ImportoRimborsato = Importo *10/100;
            return ImportoRimborsato;


        }
        public Altro(string name, double importo, double impRimb)
        {
            Name = "altro";
            Importo = importo;
            ImportoRimborsato = GetImportoRimborsato();
        }
    }
}

