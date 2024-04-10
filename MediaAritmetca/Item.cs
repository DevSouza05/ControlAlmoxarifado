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
        public string Name { get; set; }
        public string codi { get; set; }
        public string type { get; set; }
        public double amount { get; set; }

        public Item(string nome, string codigo, string tipo, double quantidade)
        {
            Name = nome;
            codi = codigo;
            type = tipo;
            amount = quantidade;
        }

    }

    public class ItemComAmount
    {
        public Item Item { get; set; }
        public double Amount { get; set; }

        public ItemComAmount(Item item, double amount)
        {
            Item = item;
            Amount = amount;
        }

    }

}
