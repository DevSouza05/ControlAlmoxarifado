using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MediaAritmetca
{
    public class Item
    {
        public string name {  get; set; }
        public string codi { get; set; }

        public string type { get; set; }
        public double amount {  get; set; }

        public Item(string nome, string codigo, string tipo, double quantidade)
        {
            name = nome;
            codi = codigo;
            type = tipo;
            amount = quantidade;
        }

    }
}
