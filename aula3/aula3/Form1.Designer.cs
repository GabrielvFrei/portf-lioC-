namespace aula3
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
            vPrecotxt = new TextBox();
            vista = new RadioButton();
            groupBox1 = new GroupBox();
            credito = new RadioButton();
            debito = new RadioButton();
            button1 = new Button();
            resultadotxt = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 103);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor total da compra:";
            label1.Click += label1_Click;
            // 
            // vPrecotxt
            // 
            vPrecotxt.Location = new Point(190, 100);
            vPrecotxt.Name = "vPrecotxt";
            vPrecotxt.Size = new Size(131, 23);
            vPrecotxt.TabIndex = 2;
            vPrecotxt.TextChanged += textBox1_TextChanged;
            // 
            // vista
            // 
            vista.AutoSize = true;
            vista.Location = new Point(6, 59);
            vista.Name = "vista";
            vista.Size = new Size(60, 19);
            vista.TabIndex = 1;
            vista.TabStop = true;
            vista.Text = "A vista";
            vista.UseVisualStyleBackColor = true;
            vista.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(credito);
            groupBox1.Controls.Add(debito);
            groupBox1.Controls.Add(vista);
            groupBox1.Location = new Point(45, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 119);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pagamento";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // credito
            // 
            credito.AutoSize = true;
            credito.Location = new Point(298, 59);
            credito.Name = "credito";
            credito.Size = new Size(64, 19);
            credito.TabIndex = 3;
            credito.TabStop = true;
            credito.Text = "Crédito";
            credito.UseVisualStyleBackColor = true;
            credito.CheckedChanged += credito_CheckedChanged;
            // 
            // debito
            // 
            debito.AutoSize = true;
            debito.Location = new Point(145, 59);
            debito.Name = "debito";
            debito.Size = new Size(60, 19);
            debito.TabIndex = 2;
            debito.TabStop = true;
            debito.Text = "Débito";
            debito.UseVisualStyleBackColor = true;
            debito.CheckedChanged += debito_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(168, 277);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 4;
            button1.Text = "Verificar Preço";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultadotxt
            // 
            resultadotxt.Location = new Point(190, 344);
            resultadotxt.Name = "resultadotxt";
            resultadotxt.Size = new Size(100, 23);
            resultadotxt.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(170, 326);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 6;
            label2.Text = "Valor total com desconto";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(457, 420);
            Controls.Add(label2);
            Controls.Add(resultadotxt);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(vPrecotxt);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox vPrecotxt;
        private RadioButton vista;
        private GroupBox groupBox1;
        private RadioButton credito;
        private RadioButton debito;
        private Button button1;
        private TextBox resultadotxt;
        private Label label2;
    }
}
