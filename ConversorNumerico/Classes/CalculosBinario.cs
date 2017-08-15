using ConversorNumerico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerico.Classes
{
    public class CalculosBinario : Calculos
    {
        public string ConverterParaBinario(string valor)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-1]+$"))
                {
                    throw new FormatException();
                }

                return "BINARIO";
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
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-1]+$"))
                {
                    throw new FormatException();
                }

                double nrDecimal = 0;

                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, @"\A\b[0-9a-fA-F]+\b\Z"))
                {
                    throw new FormatException();
                }

                int elevado = valor.Length - 1;

                string num = "";

                foreach (char valorBin in valor)
                {
                    char letra = valorBin;

                    int resto = 0;

                    resto = (int)Char.GetNumericValue(letra);

                    nrDecimal = nrDecimal + (resto * Math.Pow(2, elevado));

                    elevado = elevado - 1;
                    num = num + " - (" + nrDecimal + " / " + elevado + ")";
                }

                return "" + nrDecimal;
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
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-1]+$"))
                {
                    throw new FormatException();
                }
                
                CalculosDecimal calcDecimal = new CalculosDecimal();

                string valorDecimal = ConverterParaDecimal(valor);
                string valorHexadecimal = calcDecimal.ConverterParaHexadecimal(valorDecimal);

                return "" + valorHexadecimal;
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
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, "^[0-1]+$"))
                {
                    throw new FormatException();
                }
                
                CalculosDecimal calcDecimal = new CalculosDecimal();

                string valorDecimal = ConverterParaDecimal(valor);
                string valorOctal = calcDecimal.ConverterParaOctal(valorDecimal);

                return "" + valorOctal;
                
            }
            catch (FormatException e)
            {
                return "Valor Invalido";
            }
        }
    }
}
