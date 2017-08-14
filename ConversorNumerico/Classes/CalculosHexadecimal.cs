using ConversorNumerico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerico.Classes
{
    public class CalculosHexadecimal : Calculos
    {
        public string ConverterParaBinario(string valor)
        {
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, @"\A\b[0-9a-fA-F]+\b\Z"))
                {
                    throw new FormatException();
                }

                string binario="";

                foreach (char valorHexa in valor)
                {
                    char letra = valorHexa;

                    if (letra == 'A')
                    {
                        binario = binario+"1010";
                    }
                    else if (letra == 'B')
                    {
                        binario = binario + "1011";
                    }
                    else if (letra == 'C')
                    {
                        binario = binario + "1100";
                    }
                    else if (letra == 'D')
                    {
                        binario = binario + "1101";
                    }
                    else if (letra == 'E')
                    {
                        binario = binario + "1110";
                    }
                    else if (letra == 'F')
                    {
                        binario = binario + "1111";
                    }
                    else if (letra == '0')
                    {
                        binario = binario + "0000";
                    }
                    else if (letra == '1')
                    {
                        binario = binario + "0001";
                    }
                    else if (letra == '2')
                    {
                        binario = binario + "0010";
                    }
                    else if (letra == '3')
                    {
                        binario = binario + "0011";
                    }
                    else if (letra == '4')
                    {
                        binario = binario + "0100";
                    }
                    else if (letra == '5')
                    {
                        binario = binario + "0101";
                    }
                    else if (letra == '6')
                    {
                        binario = binario + "0110";
                    }
                    else if (letra == '7')
                    {
                        binario = binario + "0111";
                    }
                    else if (letra == '8')
                    {
                        binario = binario + "1000";
                    }
                    else if (letra == '9')
                    {
                        binario = binario + "1001";
                    }
                    

                }

                return ""+binario;
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
                double nrDecimal = 0;

                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, @"\A\b[0-9a-fA-F]+\b\Z"))
                {
                    throw new FormatException();
                }
                
                int elevado = valor.Length-1;

                string num = "";

                foreach (char valorHexa in valor)
                {
                    char letra = valorHexa;

                    int resto = 0;

                    if (letra == 'A')
                    {
                        resto = 10;
                    }
                    else if (letra == 'B')
                    {
                        resto = 11;
                    }
                    else if (letra == 'C')
                    {
                        resto = 12;
                    }
                    else if (letra == 'D')
                    {
                        resto = 13;
                    }
                    else if (letra == 'E')
                    {
                        resto = 14;
                    }
                    else if (letra == 'F')
                    {
                        resto = 15;
                    }
                    else
                    {
                        resto = (int)Char.GetNumericValue(letra);
                    }

                    if (nrDecimal == 0&&(resto!=0))
                    {
                        nrDecimal = resto * Math.Pow(16,elevado);
                    }
                    else
                    {
                        nrDecimal = nrDecimal + (resto * Math.Pow(16,elevado));
                    }
                    elevado=elevado-1;
                    num = num + " - ("+ nrDecimal +" / "+ elevado + ")";
                }

                return ""+nrDecimal;
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
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, @"\A\b[0-9a-fA-F]+\b\Z"))
                {
                    throw new FormatException();
                }

                return "HEXADECIMAL";
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
                if (!System.Text.RegularExpressions.Regex.IsMatch(valor, @"\A\b[0-9a-fA-F]+\b\Z"))
                {
                    throw new FormatException();
                }

                string decimais=ConverterParaDecimal(valor);

                CalculosDecimal calc = new CalculosDecimal();
                
                string octa = calc.ConverterParaOctal(decimais);

                return octa;
            }
            catch (FormatException e)
            {
                return "Valor Invalido";
            }
        }
    }
}
