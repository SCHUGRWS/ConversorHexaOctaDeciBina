using ConversorNumerico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerico.Classes
{
    public class CalculosOctal : Calculos
    {
        public string ConverterParaBinario(string valor)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-7]+$"))
                {
                    throw new FormatException();
                }
                
                string binario = "";

                CalculosDecimal calc = new CalculosDecimal();

                foreach (char valorOcta in valor)
                {
                    char letra = valorOcta;

                    int resto = 0;

                    resto = (int)Char.GetNumericValue(letra);

                    string bin = calc.ConverterParaBinario("" + resto);

                    if (Convert.ToInt32(bin) < 10)
                    {
                        bin = "00" + bin;
                    }
                    else if (Convert.ToInt32(bin) < 100)
                    {
                        bin = "0" + bin;
                    }

                    binario = binario + bin;

                }

                return "" + binario;
            }
            catch (FormatException e)
            {
                return "Valor Invalido";
            }
        }

        public string ConverterParaDecimal(string valor)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-7]+$"))
                {
                    throw new FormatException();
                }

                string binario = ConverterParaBinario(valor);

                CalculosBinario bin = new CalculosBinario();

                string nrDecimal = bin.ConverterParaDecimal(binario);

                return ""+ nrDecimal;
            }
            catch (FormatException e)
            {
                return "Valor Invalido";
            }
        }

        public string ConverterParaHexadecimal(string valor)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-7]+$"))
                {
                    throw new FormatException();
                }
                
                CalculosDecimal calcDecimal = new CalculosDecimal();

                string valorDecimal = ConverterParaDecimal(valor);
                string valorHexadecimal = calcDecimal.ConverterParaHexadecimal(valorDecimal);

                return ""+ valorHexadecimal;
            }
            catch (FormatException e)
            {
                return "Valor Invalido";
            }
        }

        public string ConverterParaOctal(string valor)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-7]+$"))
                {
                    throw new FormatException();
                }

                return "OCTAL";
            }
            catch (FormatException e)
            {
                return "Valor Invalido";
            }
        }
    }
}
