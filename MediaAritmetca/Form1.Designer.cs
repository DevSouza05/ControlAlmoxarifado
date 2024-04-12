namespace MediaAritmetca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            vlName = new TextBox();
            vlAmount = new TextBox();
            vlCodi = new TextBox();
            button1 = new Button();
            vlType = new ComboBox();
            checkStock = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(245, 34);
            label1.Name = "label1";
            label1.Size = new Size(350, 32);
            label1.TabIndex = 0;
            label1.Text = "CONTROLE DE ALMOXARIFADO";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 123);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 126);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Código >";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 173);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Quantidade >";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 170);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo >";
            // 
            // vlName
            // 
            vlName.Location = new Point(258, 123);
            vlName.Name = "vlName";
            vlName.Size = new Size(100, 23);
            vlName.TabIndex = 5;
            // 
            // vlAmount
            // 
            vlAmount.Location = new Point(495, 170);
            vlAmount.Name = "vlAmount";
            vlAmount.Size = new Size(100, 23);
            vlAmount.TabIndex = 7;
            // 
            // vlCodi
            // 
            vlCodi.Location = new Point(495, 123);
            vlCodi.Name = "vlCodi";
            vlCodi.Size = new Size(100, 23);
            vlCodi.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(245, 237);
            button1.Name = "button1";
            button1.Size = new Size(127, 26);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar item ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // vlType
            // 
            vlType.FormattingEnabled = true;
            vlType.ImeMode = ImeMode.NoControl;
            vlType.Items.AddRange(new object[] { "Informática", "Limpeza", "Mat. Escritório" });
            vlType.Location = new Point(258, 165);
            vlType.Name = "vlType";
            vlType.Size = new Size(100, 23);
            vlType.TabIndex = 12;
            // 
            // checkStock
            // 
            checkStock.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkStock.Location = new Point(450, 237);
            checkStock.Name = "checkStock";
            checkStock.Size = new Size(145, 26);
            checkStock.TabIndex = 13;
            checkStock.Text = "Consultar estoque";
            checkStock.UseVisualStyleBackColor = true;
            checkStock.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(837, 389);
            Controls.Add(checkStock);
            Controls.Add(vlType);
            Controls.Add(button1);
            Controls.Add(vlCodi);
            Controls.Add(vlAmount);
            Controls.Add(vlName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox vlName;
        private TextBox vlAmount;
        private TextBox vlCodi;
        private Button button1;
        private ComboBox vlType;
        private Button checkStock;
    }
}
