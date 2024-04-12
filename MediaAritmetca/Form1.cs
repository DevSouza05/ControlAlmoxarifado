using System;
using System.IO; // Importe este namespace para usar File e Directory
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics.Eventing.Reader;

namespace MediaAritmetca
{
    public partial class Form1 : Form
    {
        private ListaDeItens listaDeItens = new ListaDeItens();

        public Form1()
        {
            InitializeComponent();
        }

        //Evento do botão de cadastrar o item
        private void button1_Click(object sender, EventArgs e)
        {
            var Name = vlName.Text;
            var Codi = vlCodi.Text;
            var Type = vlType.Text;
            var Amount = vlAmount.Text;
            int amountValue;

            if (String.IsNullOrEmpty(Name) || String.IsNullOrEmpty(Codi) || String.IsNullOrEmpty(Type) || String.IsNullOrEmpty(Amount))
            {
                MessageBox.Show("Preencha o campo vazio!");
                return;
            }

            if (!int.TryParse(Amount, out amountValue))
            {
                MessageBox.Show("O campo (quantidade) deve ser preenchido com números inteiros");
                return;
            }

            listaDeItens.AdicionarItem(Name, Codi, Type, amountValue);

            string caminhoArquivo = @"C:\Caminho\Para\O\Arquivo\lista_itens.json";

            // Verifica se o diretório onde o arquivo será salvo existe. Se não existir, cria-o.
            string diretorio = Path.GetDirectoryName(caminhoArquivo);
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            listaDeItens.SerializarLista(caminhoArquivo);

            Utils.LimparCampos(vlName, vlCodi, vlType, vlAmount);

            MessageBox.Show("Item cadastrado com sucesso!");
        }

        //Event do botão de cunsultar Estoque
        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaEstoqueForm consultaEstoqueForm = new ConsultaEstoqueForm(listaDeItens.ObterLista());
            consultaEstoqueForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
