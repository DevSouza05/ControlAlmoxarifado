using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;


public class ListaDeItens
{
    private List<Item> listaDeItens = new List<Item>();

    public void AdicionarItem(string nome, string codigo, string tipo, double quantidade)
    {
        listaDeItens.Add(new Item(nome, codigo, tipo, quantidade));
    }

    public void RemoverItem(int index)
    {
        if (index >= 0 && index < listaDeItens.Count)
        {
            listaDeItens.RemoveAt(index);
        }
    }

    public void SerializarLista(string caminhoArquivo)
    {
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Item>));

        using (MemoryStream ms = new MemoryStream())
        {
            serializer.WriteObject(ms, listaDeItens);
            File.WriteAllText(caminhoArquivo, Encoding.Default.GetString(ms.ToArray()));
        }
    }

    public void DesserializarLista(string caminhoArquivo)
    {
        if (File.Exists(caminhoArquivo))
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Item>));
            string jsonString = File.ReadAllText(caminhoArquivo);
            using (MemoryStream ms = new MemoryStream(Encoding.Default.GetBytes(jsonString)))
            {
                listaDeItens = (List<Item>)serializer.ReadObject(ms);
            }
        }
    }

    public void LimparLista()
    {
        listaDeItens.Clear();
    }

    public List<Item> ObterLista()
    {
        return listaDeItens;
    }

    // Classe que representa um item
    [Serializable]
    public class Item
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public double Quantidade { get; set; }

        public Item(string nome, string codigo, string tipo, double quantidade)
        {
            Nome = nome;
            Codigo = codigo;
            Tipo = tipo;
            Quantidade = quantidade;
        }
    }
}
