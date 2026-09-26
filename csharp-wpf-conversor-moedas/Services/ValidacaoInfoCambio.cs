using csharp_wpf_conversor_moedas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_wpf_conversor_moedas.Services
{
    public class ValidacaoInfoCambio
    {
        public bool Validar(string valorTexto, OpcoesConversor moedaOrigem, OpcoesConversor moedaDestino, out decimal valorOrigem, out string mensagemErro)
        {
            if (!decimal.TryParse(valorTexto, out valorOrigem) || valorOrigem <= 0 || moedaOrigem == null || moedaDestino == null || moedaOrigem == moedaDestino)
            {
                mensagemErro = "Por favor, insira informações válidas para conversão.";
                return false;
            }

            mensagemErro = null;
            return true;
        }
    }
}