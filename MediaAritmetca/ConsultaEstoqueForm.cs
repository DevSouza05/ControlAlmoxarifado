













using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaAritmetca
{
    public partial class ConsultaEstoqueForm : Form
    {
        private List<ListaDeItens.Item> listaDeItens;

        public ConsultaEstoqueForm(List<ListaDeItens.Item> itens)
        {
            InitializeComponent();
            listaDeItens = itens;
            ConfigurarDataGridView();
            ExibirItens();
        }

        private void ConfigurarDataGridView()
        {
            // Configurações do DataGridView
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Codigo", "Código");
            dataGridView1.Columns.Add("Tipo", "Tipo");
            dataGridView1.Columns.Add("Quantidade", "Quantidade");
        }

        private void ExibirItens()
        {
            // Limpa o DataGridView
            dataGridView1.Rows.Clear();

            // Adiciona os itens ao DataGridView
            foreach (var item in listaDeItens)
            {
                dataGridView1.Rows.Add(item.Nome, item.Codigo, item.Tipo, item.Quantidade);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Você pode adicionar código aqui para manipular cliques nas células do DataGridView, se necessário
        }
    }
}



















//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace MediaAritmetca
//{
//    public partial class ConsultaEstoqueForm : Form
//    {
//        private List<ListaDeItens.Item> listaDeItens;
//        public ConsultaEstoqueForm(List<ListaDeItens.Item> itens, string caminhoArquivo)
//        {
//            InitializeComponent();
//            listaDeItens = itens;
//            ExibirItens();
//        }
//        private void ExibirItens()
//        {
//            // Limpa o ListView
//            listViewItens.Items.Clear();

//            // Adiciona os itens ao ListView
//            foreach (var item in listaDeItens)
//            {
//                ListViewItem listViewItem = new ListViewItem(new string[] { item.Nome, item.Codigo, item.Tipo, item.Quantidade.ToString() });
//                listViewItens.Items.Add(listViewItem);
//            }
//        }

//        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
//        {

//        }
//    }
//}
