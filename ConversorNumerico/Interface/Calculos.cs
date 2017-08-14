using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorNumerico.Interface
{
    public interface Calculos
    {
        string ConverterParaDecimal(string valor);
        string ConverterParaOctal(string valor);
        string ConverterParaHexadecimal(string valor);
        string ConverterParaBinario(string valor);
    }
}
