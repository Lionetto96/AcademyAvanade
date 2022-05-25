using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Entities
{
    internal class Vitto :ICategory
    {
        public string Name { get; }
        public double Importo { get; set; }
        public double ImportoRimborsato { get; set; }

        public double GetImportoRimborsato()
        {
            double ImportoRimborsato;
            
            ImportoRimborsato = Importo * 70 /100;
            return ImportoRimborsato;


        }
        public Vitto(string name, double importo, double impRimb)
        {
            Name = "vitto";
            Importo = importo;
            ImportoRimborsato = GetImportoRimborsato();
        }
    }
}

