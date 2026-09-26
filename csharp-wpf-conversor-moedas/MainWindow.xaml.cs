using csharp_wpf_conversor_moedas.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace csharp_wpf_conversor_moedas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MoedaService _moedaService;
        public MainWindow()
        {
            InitializeComponent();
            _moedaService = new MoedaService();
            DataContext = _moedaService;
        }

        private void InverterBtn_click(object sender, RoutedEventArgs e)
        {
            var inverterConversao = cmbMoedaOrigem.SelectedItem;
            cmbMoedaOrigem.SelectedItem = cmbMoedaDestino.SelectedItem;
            cmbMoedaDestino.SelectedItem = inverterConversao;
        }
    }
}