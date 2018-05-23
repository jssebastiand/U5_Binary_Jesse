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

namespace BINARY
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
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {

            string input = txtInput.Text;
            input = input.Replace("1", "1"); Console.WriteLine(input);
            input = input.Replace("2", "10"); Console.WriteLine(input);
            input = input.Replace("3", "11"); Console.WriteLine(input);
            input = input.Replace("4", "100"); Console.WriteLine(input);
            input = input.Replace("5", "101"); Console.WriteLine(input);
            input = input.Replace("6)", "110"); Console.WriteLine(input);
            input = input.Replace("7", "111"); Console.WriteLine(input);
            input = input.Replace("8", "1000"); Console.WriteLine(input);
            input = input.Replace("9", "1001"); Console.WriteLine(input);
            input = input.Replace("10", "1010"); Console.WriteLine(input);
            input = input.Replace("11", "1011"); Console.WriteLine(input);
            input = input.Replace("12", "1100"); Console.WriteLine(input);
            input = input.Replace("13", "1101"); Console.WriteLine(input);
            input = input.Replace("14", " 1110"); Console.WriteLine(input);
            input = input.Replace("15", " 1111"); Console.WriteLine(input);
            input = input.Replace("16", " 10000"); Console.WriteLine(input);
            input = input.Replace("17", " 10001"); Console.WriteLine(input);
            input = input.Replace("18", " 10010"); Console.WriteLine(input);
            input = input.Replace("19", " 10011"); Console.WriteLine(input);
            input = input.Replace("20", " 10100"); Console.WriteLine(input);


            //Output full end string.
            string output = input;
            lblOutput.Content = output;
            ;
        }

        private void txtInput_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }
    }
}
