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
            this.SuspendLayout();
            // 
            // comboTipoOperacao
            // 
            this.comboTipoOperacao.FormattingEnabled = true;
            this.comboTipoOperacao.Location = new System.Drawing.Point(85, 54);
            this.comboTipoOperacao.Name = "comboTipoOperacao";
            this.comboTipoOperacao.Size = new System.Drawing.Size(121, 21);
            this.comboTipoOperacao.TabIndex = 0;
            this.comboTipoOperacao.SelectedIndexChanged += new System.EventHandler(this.comboTipoOperacao_SelectedIndexChanged);
            // 
            // tbValorDigitado
            // 
            this.tbValorDigitado.Location = new System.Drawing.Point(85, 114);
            this.tbValorDigitado.Name = "tbValorDigitado";
            this.tbValorDigitado.Size = new System.Drawing.Size(100, 20);
            this.tbValorDigitado.TabIndex = 1;
            // 
            // btConverter
            // 
            this.btConverter.Location = new System.Drawing.Point(111, 162);
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
            this.lbBinario.Location = new System.Drawing.Point(41, 195);
            this.lbBinario.Name = "lbBinario";
            this.lbBinario.Size = new System.Drawing.Size(35, 13);
            this.lbBinario.TabIndex = 3;
            this.lbBinario.Text = "label1";
            // 
            // lbDecimal
            // 
            this.lbDecimal.AutoSize = true;
            this.lbDecimal.Location = new System.Drawing.Point(237, 223);
            this.lbDecimal.Name = "lbDecimal";
            this.lbDecimal.Size = new System.Drawing.Size(35, 13);
            this.lbDecimal.TabIndex = 4;
            this.lbDecimal.Text = "label1";
            // 
            // lbHexadecimal
            // 
            this.lbHexadecimal.AutoSize = true;
            this.lbHexadecimal.Location = new System.Drawing.Point(237, 195);
            this.lbHexadecimal.Name = "lbHexadecimal";
            this.lbHexadecimal.Size = new System.Drawing.Size(35, 13);
            this.lbHexadecimal.TabIndex = 5;
            this.lbHexadecimal.Text = "label1";
            // 
            // lbOctal
            // 
            this.lbOctal.AutoSize = true;
            this.lbOctal.Location = new System.Drawing.Point(41, 223);
            this.lbOctal.Name = "lbOctal";
            this.lbOctal.Size = new System.Drawing.Size(35, 13);
            this.lbOctal.TabIndex = 6;
            this.lbOctal.Text = "label1";
            // 
            // ConversorNumerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 267);
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
    }
}