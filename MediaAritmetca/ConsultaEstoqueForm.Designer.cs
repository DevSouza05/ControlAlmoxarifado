namespace MediaAritmetca
{
    partial class ConsultaEstoqueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            btnBuscar = new Button();
            dataGridView1 = new DataGridView();
            clItem = new DataGridViewTextBoxColumn();
            clCodigo = new DataGridViewTextBoxColumn();
            clTipo = new DataGridViewTextBoxColumn();
            clQuantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(159, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 23);
            comboBox1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(431, 71);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(72, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Filtrar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clItem, clCodigo, clTipo, clQuantidade });
            dataGridView1.Location = new Point(113, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 190);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clItem
            // 
            clItem.HeaderText = "Item";
            clItem.Name = "clItem";
            // 
            // clCodigo
            // 
            clCodigo.HeaderText = "Codigo";
            clCodigo.Name = "clCodigo";
            // 
            // clTipo
            // 
            clTipo.HeaderText = "Tipo";
            clTipo.Name = "clTipo";
            // 
            // clQuantidade
            // 
            clQuantidade.HeaderText = "Quantidade";
            clQuantidade.Name = "clQuantidade";
            // 
            // ConsultaEstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnBuscar);
            Controls.Add(comboBox1);
            Name = "ConsultaEstoqueForm";
            Text = "ConsultaEstoqueForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private Button btnBuscar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clItem;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clTipo;
        private DataGridViewTextBoxColumn clQuantidade;
    }
}