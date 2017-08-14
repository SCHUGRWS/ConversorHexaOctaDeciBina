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
            lbBinario.Text = ""+Convert.ToInt64(calculo.ConverterParaBinario(tbValorDigitado.Text));
            lbDecimal.Text = calculo.ConverterParaDecimal(tbValorDigitado.Text);
            lbHexadecimal.Text = calculo.ConverterParaHexadecimal(tbValorDigitado.Text);
            lbOctal.Text = calculo.ConverterParaOctal(tbValorDigitado.Text);
        }
    }
}
