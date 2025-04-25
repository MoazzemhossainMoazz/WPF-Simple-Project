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

namespace ListBox4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> numberList = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PickRandomNumbers_Click(object sender, RoutedEventArgs e)
        {
            if (numberList.Count == 0)
            {
                MessageBox.Show("Please enter some numbers first!");
                return;
            }

            Random rnd = new Random();
            var randomNumbers = numberList.OrderBy(x => rnd.Next()).Take(5).ToList();

            ResultListBox.ItemsSource = randomNumbers;
        }

        private void NumberInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out _);
        }

        private void NumberInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && int.TryParse(NumberInput.Text, out int number))
            {
                numberList.Add(number);
                NumberInput.Clear();
            }
        }
    }
}
