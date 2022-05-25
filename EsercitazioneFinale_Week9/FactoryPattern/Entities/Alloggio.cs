using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Entities
{
    internal class Alloggio : ICategory
    {
        public string Name { get;  }
        public double Importo { get; set; }

        public double ImportoRimborsato { get; set; }
        public double GetImportoRimborsato()
        {
            double ImportoRimborsato;
            ImportoRimborsato = Importo;
            return ImportoRimborsato;


        }
        

        public Alloggio(string name,double importo,double impRimb)
        {
            Name = "alloggio";
            Importo = importo;
            ImportoRimborsato = GetImportoRimborsato();
        }
    }
}
