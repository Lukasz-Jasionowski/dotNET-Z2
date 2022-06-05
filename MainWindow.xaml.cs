using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

namespace dotNET_Z2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        char mar;
        float num1, num2;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Procent_Click(object sender, RoutedEventArgs e)
        {
            mar = '%';
            num1 = float.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
        }

        private void Cofnij_Click(object sender, RoutedEventArgs e)
        {

        }

        private void JedenPrzezX_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DoKwadratu_Click(object sender, RoutedEventArgs e)
        {
            num1 = float.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = (num1 * num1).ToString();
            num1 *= num1;
        }

        private void Pierwiastek_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Podziel_Click(object sender, RoutedEventArgs e)
        {
            mar = '/';
            num1 = float.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
        }

        private void Siedem_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "7";
        }

        private void Osiem_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "8";
        }

        private void Dziewiec_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "9";
        }

        private void Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            mar = '*';
            num1 = float.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
        }

        private void Cztery_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "4";
        }

        private void Piec_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "5";
        }

        private void Szesc_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "6";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            mar = '-';
            num1 = float.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
        }

        private void Jeden_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "1";
        }

        private void Dwa_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "2";
        }

        private void Trzy_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "3";
        }

        private void Dodac_Click(object sender, RoutedEventArgs e)
        {
            mar = '+';
            num1 = float.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
        }

        private void ZmianaZnaku_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "0";
        }

        private void Przecinek_Click(object sender, RoutedEventArgs e)
        {
            text.Text += ".";
        }

        private void RownaSie_Click(object sender, RoutedEventArgs e)
        {
            num2 = float.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            if (mar == '+')
            {
                text.Text = (num1 + num2).ToString();
                num1 += num2;
            }
            else if (mar == '-')
            {
                text.Text = (num1 - num2).ToString();
                num1 -= num2;
            }
            else if (mar == '*')
            {
                text.Text = (num1 * num2).ToString();
                num1 *= num2;
            }
            else if (mar == '/')
            {
                text.Text = (num1 / num2).ToString();
                num1 /= num2;
            }
            else if (mar == '%')
            {
                text.Text = (num1 % num2).ToString();
                num1 %= num2;
            }
        }
    }
}