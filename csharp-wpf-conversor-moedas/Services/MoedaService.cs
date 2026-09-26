using csharp_wpf_conversor_moedas.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_wpf_conversor_moedas.Services
{
    public class MoedaService
    {
        public ObservableCollection<OpcoesConversor> ListaMonetaria { get; set; }
        public MoedaService()
        { 
            ListaMonetaria = new ObservableCollection<OpcoesConversor>
            {
                new OpcoesConversor { Sigla = "USD", 
                    Bandeira = new System.Windows.Media.Imaging.BitmapImage(new Uri("/Resources/Assets/estados-unidos.png", UriKind.Relative)), 
                    Taxa = 1.0M },
                new OpcoesConversor { Sigla = "GBP", 
                    Bandeira = new System.Windows.Media.Imaging.BitmapImage(new Uri("/Resources/Assets/reino-unido.png", UriKind.Relative)),
                    Taxa = 0.75M },
                new OpcoesConversor { Sigla = "BRL", Bandeira = new System.Windows.Media.Imaging.BitmapImage(new Uri("/Resources/Assets/brasil.png", UriKind.Relative)), 
                    Taxa = 5.0M },
                new OpcoesConversor { Sigla = "JPY", 
                    Bandeira = new System.Windows.Media.Imaging.BitmapImage(new Uri("/Resources/Assets/japao.png", UriKind.Relative)), 
                    Taxa = 110.0M },
                new OpcoesConversor { Sigla = "EUR", 
                    Bandeira = new System.Windows.Media.Imaging.BitmapImage(new Uri("/Resources/Assets/uniao-europeia.png", UriKind.Relative)), 
                    Taxa = 0.85M }
            };
        }
    }
}
