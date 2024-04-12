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
            cmbTipo = new ComboBox();
            btnFilter = new Button();
            dataGridView1 = new DataGridView();
            clItem = new DataGridViewTextBoxColumn();
            clCodigo = new DataGridViewTextBoxColumn();
            clTipo = new DataGridViewTextBoxColumn();
            clQuantidade = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Informática", "Limpeza", "Mat.Escritório" });
            cmbTipo.Location = new Point(159, 71);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(266, 23);
            cmbTipo.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(431, 71);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(72, 23);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
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
            Controls.Add(btnFilter);
            Controls.Add(cmbTipo);
            Name = "ConsultaEstoqueForm";
            Text = "ConsultaEstoqueForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cmbTipo;
        private Button btnFilter;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clItem;
        private DataGridViewTextBoxColumn clCodigo;
        private DataGridViewTextBoxColumn clTipo;
        private DataGridViewTextBoxColumn clQuantidade;
    }
}