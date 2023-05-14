using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StrongPointHomeTask.Properties;

namespace StrongPointHomeTask.Functions
{
    public class ConfigJson
    {
        public static DataList dataTable = new DataList(); //Sarasas kuris bus naudojamas visoje programoje
        public async Task GetDataAsync() //Saraso istraukimas is failo
        {
            var json = string.Empty;
            //Naudojame newtonsoft.json prieda
            using (var fs = File.OpenRead(@"..\..\Functions\data.json"))//Keliaujame i Functions folderi
            using (var sr = new StreamReader(fs, new UTF8Encoding(false))) //Jame skaitome visas eilutes viena po viena
                json = await sr.ReadToEndAsync().ConfigureAwait(false); //Skaitome iki galo ir isidedame i kintamaji

            dataTable = JsonConvert.DeserializeObject<DataList>(json); //Visa nuskaityta informacija isidedame i musu sarasa (Deserializuojame json teksta)
        }

        public async Task StoreDataAsync() //Saraso irasymas i faila
        {
            var json = JsonConvert.SerializeObject(dataTable); //Pagrindini sarasa serializuojame i json teksta
            File.WriteAllText(@"..\..\Functions\data.json", json); //Si teksta idedame i data.json faila
        }
    }
}
