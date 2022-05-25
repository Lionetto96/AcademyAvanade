using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Entities
{
    internal class Viaggio :ICategory
    {
        public string Name { get; }
        public double Importo { get; set; }
        public double ImportoRimborsato { get; set; }
        public double GetImportoRimborsato()
        {
            double ImportoRimborsato;
            ImportoRimborsato = Importo + 50;
            return ImportoRimborsato;


        }

        public Viaggio(string name, double importo, double impRimb)
        {
            Name = "viaggio";
            Importo = importo;
            ImportoRimborsato = GetImportoRimborsato();
        }
    }
}

