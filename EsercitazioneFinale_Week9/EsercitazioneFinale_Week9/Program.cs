using System;
using System.IO;

namespace EsercitazioneFinale_Week9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manager.WriteFile(new DateTime(2022,01,19),"viaggio","trasferta visita medica",150.90);
            //Manager.WriteFile(new DateTime(2022, 01, 15), "vitto", "pasto", 18.50);
            //Manager.WriteFile(new DateTime(2022, 01, 01), "alloggio", "hotel Riccione", 120.90);
            var l = Manager.ReadFile();
            bool a= Manager.Approved();
            Manager.SaveRimborsi(l);


            

           

        }
    }
}
