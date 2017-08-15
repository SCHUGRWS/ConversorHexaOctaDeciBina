using ConversorNumerico.Classes;
using ConversorNumerico.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorNumerico
{
    public partial class ConversorNumerico : Form
    {
        Calculos calculo;

        public ConversorNumerico()
        {
            InitializeComponent();
            comboTipoOperacao.Items.Add("Decimal");
            comboTipoOperacao.Items.Add("Binário");
            comboTipoOperacao.Items.Add("Octal");
            comboTipoOperacao.Items.Add("Hexadecimal");
            comboTipoOperacao.SelectedIndex = 0;
        }

        private void comboTipoOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboTipoOperacao.SelectedIndex;
            if (index == 0)
            {
                calculo = new CalculosDecimal();
            }
            if (index == 1)
            {
                calculo = new CalculosBinario();
            }
            if (index == 2)
            {
                calculo = new CalculosOctal();
            }
            if (index == 3)
            {
                calculo = new CalculosHexadecimal();
            }
        }

        private void btConverter_Click(object sender, EventArgs e)
        {

            string valor = tbValorDigitado.Text;
            valor = valor.ToUpper();

            if (valor != "")
            {

                lbBinario.Text = calculo.ConverterParaBinario(valor);
                lbDecimal.Text = calculo.ConverterParaDecimal(valor);
                lbHexadecimal.Text = calculo.ConverterParaHexadecimal(valor);
                lbOctal.Text = calculo.ConverterParaOctal(valor);

            }
            else
            {
                MessageBox.Show("Valor: Campo Obrigatório!");
            }
        }
    }
}
