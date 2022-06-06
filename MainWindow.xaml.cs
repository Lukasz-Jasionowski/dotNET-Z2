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
        double num1, num2;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Modulo_Click(object sender, RoutedEventArgs e)
        {
            mar = '%';
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            display.Text += "%";
            text.Text = "";
        }

        private void Silnia_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            double silnia = 1;
            for (int i = 1; i <= num1; i++)
            {
                silnia *= i;
            }
            display.Text = num1 + "n!" + "=" + silnia.ToString();
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            display.Text = "";
        }

        private void Floor_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            Obliczenia obliczenia = new Obliczenia();
            num1 = obliczenia.Floor(num1);
            text.Text = num1.ToString();
            display.Text += "↓=" + num1.ToString();
        }

        private void Ceiling_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            Obliczenia obliczenia = new Obliczenia();
            num1 = obliczenia.Ceiling(num1);
            text.Text = num1.ToString();
            display.Text += "↑=" + num1.ToString();
        }

        private void DoKwadratu_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = (num1 * num1).ToString();
            display.Text += num1.ToString() + "*" + num1.ToString();
            num1 *= num1;
        }

        private void Pierwiastek_Click(object sender, RoutedEventArgs e)
        {
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            Obliczenia obliczenia = new Obliczenia();
            num1 = obliczenia.Sqrt(num1);
            text.Text = num1.ToString();
            display.Text += "√" + "=" + num1.ToString();
        }

        private void Podziel_Click(object sender, RoutedEventArgs e)
        {
            mar = '/';
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            display.Text += "/";
            text.Text = "";
        }

        private void Siedem_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "7";
            display.Text += "7";
        }

        private void Osiem_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "8";
            display.Text += "8";
        }

        private void Dziewiec_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "9";
            display.Text += "9";
        }

        private void Mnozenie_Click(object sender, RoutedEventArgs e)
        {
            mar = '*';
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
            display.Text += "*";
        }

        private void Cztery_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "4";
            display.Text += "4";
        }

        private void Piec_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "5";
            display.Text += "5";
        }

        private void Szesc_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "6";
            display.Text += "6";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            mar = '-';
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
            display.Text += "-";
        }

        private void Jeden_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "1";
            display.Text += "1";
        }

        private void Dwa_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "2";
            display.Text += "2";
        }

        private void Trzy_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "3";
            display.Text += "3";
        }

        private void Dodac_Click(object sender, RoutedEventArgs e)
        {
            mar = '+';
            num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            text.Text = "";
            display.Text += "+";
        }

        private void ZmianaZnaku_Click(object sender, RoutedEventArgs e)
        {
            if (!text.Text.Contains("-"))
            {
                num1 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
                text.Text += "-";
                display.Text = (num1 * -1).ToString();
                text.Text = (num1 * -1).ToString();
                num1 *= -1;
            }
            else
            {
                text.Text = (num1 * -1).ToString();
                num1 *= -1;
                display.Text = (num1).ToString();
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            text.Text += "0";
            display.Text += "0";
        }

        private void Przecinek_Click(object sender, RoutedEventArgs e)
        {
            text.Text += ".";
            display.Text += ",";
        }

        private void RownaSie_Click(object sender, RoutedEventArgs e)
        {
            num2 = double.Parse(text.Text, CultureInfo.InvariantCulture.NumberFormat);
            if (mar == '+')
            {
                text.Text = (num1 + num2).ToString();
                num1 += num2;
                display.Text += "=" + num1;
            }
            else if (mar == '-')
            {
                text.Text = (num1 - num2).ToString();
                num1 -= num2;
                display.Text += "=" + num1;
            }
            else if (mar == '*')
            {
                text.Text = (num1 * num2).ToString();
                num1 *= num2;
                display.Text += "=" + num1;
            }
            else if (mar == '/')
            {
                text.Text = (num1 / num2).ToString();
                num1 /= num2;
                display.Text += "=" + num1;
            }
            else if (mar == '%')
            {
                text.Text = (num1 % num2).ToString();
                num1 %= num2;
                display.Text += "=" + num1;
            }
        }
    }
}