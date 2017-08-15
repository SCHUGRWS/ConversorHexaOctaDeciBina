using ConversorNumerico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerico.Classes
{
    public class CalculosDecimal : Calculos
    {
        public string ConverterParaBinario(string valor)
        {
            try
            {
                decimal numeroD = Convert.ToDecimal(valor);
                if (valor.IndexOf('.') > 0)
                {
                    valor = valor.Split('.')[0];
                }
                if (valor.IndexOf(',') > 0)
                {
                    valor = valor.Split(',')[0];
                }
                int numero = Convert.ToInt32(valor);
                int ultimoValor = numero;
                string binario = "";
                for (int i = 0; ultimoValor >= 1; i++)
                {
                    if (ultimoValor % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    ultimoValor = (int)(ultimoValor / 2);
                }
                if (binario == "")
                {
                    binario = "0";
                }

                return binario;
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
                decimal numeroD = Convert.ToDecimal(valor);
                if (valor.IndexOf('.') > 0)
                {
                    valor = valor.Split('.')[0];
                }
                if (valor.IndexOf(',') > 0)
                {
                    valor = valor.Split(',')[0];
                }
                int numero = Convert.ToInt32(valor);

                return "DECIMAL";
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
                decimal numeroD = Convert.ToDecimal(valor);
                if (valor.IndexOf('.') > 0)
                {
                    valor = valor.Split('.')[0];
                }
                if (valor.IndexOf(',') > 0)
                {
                    valor = valor.Split(',')[0];
                }
                int numero = Convert.ToInt32(valor);
                int ultimoValor = numero;
                String hexadecimal = "";
                for (int i = 0; ultimoValor >= 16; i++)
                {
                    int resto = ultimoValor % 16;
                    if (resto == 10)
                    {
                        hexadecimal = "A" + hexadecimal;
                    }
                    else if(resto == 11)
                    {
                        hexadecimal = "B" + hexadecimal;
                    }
                    else if (resto == 12)
                    {
                        hexadecimal = "C" + hexadecimal;
                    }
                    else if (resto == 13)
                    {
                        hexadecimal = "D" + hexadecimal;
                    }
                    else if (resto == 14)
                    {
                        hexadecimal = "E" + hexadecimal;
                    }
                    else if (resto == 15)
                    {
                        hexadecimal = "F" + hexadecimal;
                    }else
                    {
                        hexadecimal = "" + resto + hexadecimal;
                    }
                    ultimoValor = (int)(ultimoValor / 16);
                }
                hexadecimal = "" + ultimoValor + hexadecimal;
                if (hexadecimal == "")
                {
                    hexadecimal = "0";
                }

                return hexadecimal;
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
                decimal numeroD = Convert.ToDecimal(valor);
                if (valor.IndexOf('.') > 0)
                {
                    valor = valor.Split('.')[0];
                }
                if (valor.IndexOf(',') > 0)
                {
                    valor = valor.Split(',')[0];
                }
                int numero = Convert.ToInt32(valor);
                int ultimoValor = numero;
                String octal = "";
                for (int i = 0; ultimoValor >= 8; i++)
                {
                    int resto = ultimoValor % 8;
                    octal = "" + resto + octal;
                    ultimoValor = (int)(ultimoValor / 8);
                }
                octal = "" + ultimoValor + octal;
                if (octal == "")
                {
                    octal = "0";
                }

                return octal;
            }
            catch (FormatException e)
            {
                return "Valor Invalido";
            }
        }
    }
}
