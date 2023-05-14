using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StrongPointHomeTask.Functions
{
    //Property failas
    public class DataList //Sis propertie laiko musu elementu sarasa
    {
        public List<Item> Items { get; set; }
        public DataList()
        {
            Items = new List<Item>();
        }
    }
    public class Item//Vieno elemento apibudinimas
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public int Kiekis { get; set; }
        public double Kaina { get; set; }
    }
}
