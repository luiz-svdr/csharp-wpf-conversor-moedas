using csharp_wpf_conversor_moedas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_wpf_conversor_moedas.Services
{
    public class CambioMoedas
    {
        public decimal Converter(OpcoesConversor origem, OpcoesConversor destino, decimal valor)
        {
            decimal valorEmDolar = valor / origem.Taxa;
            decimal valorConvertido = valorEmDolar * destino.Taxa;
            return valorConvertido;
        }
    }
}