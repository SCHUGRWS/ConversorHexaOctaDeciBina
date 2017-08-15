namespace ConversorNumerico
{
    partial class ConversorNumerico
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
            this.comboTipoOperacao = new System.Windows.Forms.ComboBox();
            this.tbValorDigitado = new System.Windows.Forms.TextBox();
            this.btConverter = new System.Windows.Forms.Button();
            this.lbBinario = new System.Windows.Forms.Label();
            this.lbDecimal = new System.Windows.Forms.Label();
            this.lbHexadecimal = new System.Windows.Forms.Label();
            this.lbOctal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboTipoOperacao
            // 
            this.comboTipoOperacao.FormattingEnabled = true;
            this.comboTipoOperacao.Location = new System.Drawing.Point(77, 54);
            this.comboTipoOperacao.Name = "comboTipoOperacao";
            this.comboTipoOperacao.Size = new System.Drawing.Size(146, 21);
            this.comboTipoOperacao.TabIndex = 0;
            this.comboTipoOperacao.SelectedIndexChanged += new System.EventHandler(this.comboTipoOperacao_SelectedIndexChanged);
            // 
            // tbValorDigitado
            // 
            this.tbValorDigitado.Location = new System.Drawing.Point(77, 99);
            this.tbValorDigitado.Name = "tbValorDigitado";
            this.tbValorDigitado.Size = new System.Drawing.Size(146, 20);
            this.tbValorDigitado.TabIndex = 1;
            // 
            // btConverter
            // 
            this.btConverter.Location = new System.Drawing.Point(108, 145);
            this.btConverter.Name = "btConverter";
            this.btConverter.Size = new System.Drawing.Size(75, 23);
            this.btConverter.TabIndex = 2;
            this.btConverter.Text = "Converter";
            this.btConverter.UseVisualStyleBackColor = true;
            this.btConverter.Click += new System.EventHandler(this.btConverter_Click);
            // 
            // lbBinario
            // 
            this.lbBinario.AutoSize = true;
            this.lbBinario.Location = new System.Drawing.Point(320, 54);
            this.lbBinario.Name = "lbBinario";
            this.lbBinario.Size = new System.Drawing.Size(0, 13);
            this.lbBinario.TabIndex = 3;
            // 
            // lbDecimal
            // 
            this.lbDecimal.AutoSize = true;
            this.lbDecimal.Location = new System.Drawing.Point(320, 150);
            this.lbDecimal.Name = "lbDecimal";
            this.lbDecimal.Size = new System.Drawing.Size(0, 13);
            this.lbDecimal.TabIndex = 4;
            // 
            // lbHexadecimal
            // 
            this.lbHexadecimal.AutoSize = true;
            this.lbHexadecimal.Location = new System.Drawing.Point(320, 117);
            this.lbHexadecimal.Name = "lbHexadecimal";
            this.lbHexadecimal.Size = new System.Drawing.Size(0, 13);
            this.lbHexadecimal.TabIndex = 5;
            // 
            // lbOctal
            // 
            this.lbOctal.AutoSize = true;
            this.lbOctal.Location = new System.Drawing.Point(320, 84);
            this.lbOctal.Name = "lbOctal";
            this.lbOctal.Size = new System.Drawing.Size(0, 13);
            this.lbOctal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Octal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hexadecimal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decimal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Binário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Formato:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor:";
            // 
            // ConversorNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 227);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbOctal);
            this.Controls.Add(this.lbHexadecimal);
            this.Controls.Add(this.lbDecimal);
            this.Controls.Add(this.lbBinario);
            this.Controls.Add(this.btConverter);
            this.Controls.Add(this.tbValorDigitado);
            this.Controls.Add(this.comboTipoOperacao);
            this.Name = "ConversorNumerico";
            this.Text = "ConversorNumerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTipoOperacao;
        private System.Windows.Forms.TextBox tbValorDigitado;
        private System.Windows.Forms.Button btConverter;
        private System.Windows.Forms.Label lbBinario;
        private System.Windows.Forms.Label lbDecimal;
        private System.Windows.Forms.Label lbHexadecimal;
        private System.Windows.Forms.Label lbOctal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}