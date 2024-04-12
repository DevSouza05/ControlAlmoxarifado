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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Informática", "Limpeza", "Mat.Escritório" });
            cmbTipo.Location = new Point(167, 72);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(187, 23);
            cmbTipo.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFilter.Location = new Point(382, 72);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(105, 23);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clItem, clCodigo, clTipo, clQuantidade });
            dataGridView1.Location = new Point(167, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 181);
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(503, 72);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 4;
            button1.Text = "Movimentações";
            button1.UseVisualStyleBackColor = true;
            // 
            // ConsultaEstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
        private Button button1;
    }
}