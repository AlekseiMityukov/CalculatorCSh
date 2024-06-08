using System.Data;
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

namespace CalculatorCSh
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

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var currentButton = sender as Button;

            if (currentButton != null && currentButton.Content is string buttonText) 
            {
                textBox1.Text += buttonText;
            }
        }

        private void ButtonEqua_Click(object sender, RoutedEventArgs e)
        {
            var summ = new DataTable();
            textBox1.Text = summ.Compute(textBox1.Text, "").ToString();
        }

        private void ButtonDellLast_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            for(int i = 0; i < textBox1.Text.Length - 1; i++) 
            {
                str += textBox1.Text[i];
            }
            textBox1.Text = str;
        }

        private void ButtonDellAll_Click(object sender, RoutedEventArgs e) 
        {
            textBox1.Text = "";
        }
    }
}