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

namespace Sum2Values
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        //    if (double.TryParse(txtValue1.Text, out double val1) &&
        //double.TryParse(txtValue2.Text, out double val2))
        //    {
        //        double sum = val1 + val2;
        //        txtResult.Text = $"Result: {sum}";
        //    }
        //    else
        //    {
        //        txtResult.Text = "Please enter valid numbers.";
        //    }
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double val1 = double.Parse(txtValue1.Text);
            double val2 = double.Parse(txtValue2.Text);
            double val3 = double.Parse(txtValue3.Text);
            double result1 = val1 + val2 + val3;
            txtResult.Text = result1.ToString();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var winabc = new Window1();
            winabc.Show();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            var winabc = new Window2();
            winabc.Show();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            var winabc = new Window3();
            winabc.Show();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            var winabc = new Window4();
            //winabc.Show();
            winabc.ShowDialog();

        }
    }
}