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

namespace Exercicio_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_igual_Click(object sender, RoutedEventArgs e)
        {
            //Obter os valores da caixa de texto
            string valor1 = valor_1_textBox.Text;
            string valor2 = valor_2_textBox.Text;
            string operacaoString = operacao_textBox.Text;

            //Converter string para int
            int valorInt1 = Convert.ToInt32(valor1);
            int valorInt2 = Convert.ToInt32(valor2);

            if (operacaoString == "+")
            {
                int somaInt = valorInt1 + valorInt2;
                string somaFinal = Convert.ToString(somaInt);
                resultado_textBox.Text = somaFinal;

            }
            else if (operacaoString == "-")
            {
                int subtracaoInt = valorInt1 - valorInt2;
                string subtracaoFinal = Convert.ToString(subtracaoInt);
                resultado_textBox.Text = subtracaoFinal;
            }
            else if (operacaoString == "*")
            {
                int multiplicacaoInt = valorInt1 * valorInt2;
                string multiplicacaoFinal = Convert.ToString(multiplicacaoInt);
                resultado_textBox.Text = multiplicacaoFinal;
            }
            else if (operacaoString == "/")
            {
                int divisaoInt = valorInt1 / valorInt2;
                string divisaoFinal = Convert.ToString(divisaoInt);
                resultado_textBox.Text = divisaoFinal;
            }
            else
            {
                resultado_textBox.Text = "Operador errado";
            }
        }
    }
}
