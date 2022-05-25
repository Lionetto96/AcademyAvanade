using FactoryPattern.Factories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EsercitazioneFinale_Week9
{
    internal class Manager
    {
        
        
        const string path = @"C:\Users\alessia.lionetto\source\repos\Week9\EsercitazioneFinale_Week9\Spese.txt";
        const string path2 = @"C:\Users\alessia.lionetto\source\repos\Week9\EsercitazioneFinale_Week9\rimborso_spese.txt";
        internal static void WriteFile(DateTime data, string categoria, string descrizione, double importo)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"data {data}; - categoria: {categoria}; descrizione: {descrizione}; importo: {importo}" );
            }
        }
        internal static void SaveRimborsi(List<string> spesa)
        {
            
            using (StreamWriter sw = new StreamWriter(path2, true))
            {
                foreach (string spesaItem in spesa)
                {
                    if (Approved())
                    {

                        sw.WriteLine($"data {spesaItem[0]};  categoria: {spesaItem[1]}; descrizione: {spesaItem[2]}; APPROVATA ; Rimborso: {spesaItem[4]}");
                    }
                    else
                    {
                        sw.WriteLine($"data { spesaItem[0]}; categoria: { spesaItem[1]}; descrizione: { spesaItem[2]}; RESPINTA; rimborso: - ");
                    };

                }

            }
        }
        internal static List<string> ReadFile()
        {
           

            List<string> list = new List<string>();

            using (StreamReader sr = new StreamReader(path))
            {
                string allSpese = sr.ReadToEnd(); //leggo tutto il contenuto del file

                //con Split sulla stringa che contiene tutto il contenuto del file
                //ottengo un array contentente le righe
                //=> ogni elemento dell'array sarà una riga del file di testo
                string[] rows = allSpese.Split("\r\n",StringSplitOptions.RemoveEmptyEntries);
                foreach (string row in rows)
                {
                    var field=row.Split(";",StringSplitOptions.RemoveEmptyEntries);
                    
                    string Data = field[0];
                    string categoria=field[1];
                    string descrizione=field[2];
                    string importo=field[3];
                    if(row != " ")
                    {
                        list.Add(row);
                    }
                    
                }

                
            }
            return list;

            
        }
        internal static  bool Approved()
        {
            var l = Manager.ReadFile();
            foreach (var row in l)
            {

                if (row[3] > 2500)
                {
                    return false;
                }


            }
            return true;

        }

    }
}
