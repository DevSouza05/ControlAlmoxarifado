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
            listViewItens = new ListView();
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
            // listViewItens
            // 
            listViewItens.Location = new Point(159, 111);
            listViewItens.Name = "listViewItens";
            listViewItens.Size = new Size(344, 176);
            listViewItens.TabIndex = 0;
            listViewItens.UseCompatibleStateImageBehavior = false;
            // 
            // ConsultaEstoqueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewItens);
            Controls.Add(btnBuscar);
            Controls.Add(comboBox1);
            Name = "ConsultaEstoqueForm";
            Text = "ConsultaEstoqueForm";
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBox1;
        private Button btnBuscar;
        private ListView listViewItens;
    }
}