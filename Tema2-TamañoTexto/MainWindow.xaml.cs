using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_TamañoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            pequeñoRadioButton.IsChecked = true;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton).Tag.Equals("pequeño")) {
                textoTextBlock.FontSize = 36;
            }
            else if ((sender as RadioButton).Tag.Equals("mediano"))
            {
                textoTextBlock.FontSize = 48;
            }
            else if ((sender as RadioButton).Tag.Equals("grande"))
            {
                textoTextBlock.FontSize = 72;
            }
        }
    }
}
