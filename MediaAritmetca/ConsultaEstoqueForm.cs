using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaAritmetca
{
    public partial class ConsultaEstoqueForm : Form
    {
       private List<ListaDeItens.Item> listaDeItens;
        public ConsultaEstoqueForm(List<ListaDeItens.Item> itens, string caminhoArquivo)
        {
        InitializeComponent();
            listaDeItens = itens;
            ExibirItens();
        }
        private void ExibirItens()
        {
            // Limpa o ListView
            listViewItens.Items.Clear();

            // Adiciona os itens ao ListView
            foreach (var item in listaDeItens)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] { item.Nome, item.Codigo, item.Tipo, item.Quantidade.ToString() });
                listViewItens.Items.Add(listViewItem);
            }
        }
    }
}
