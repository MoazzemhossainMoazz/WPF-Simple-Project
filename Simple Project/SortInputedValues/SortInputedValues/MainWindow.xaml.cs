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

namespace SortInputedValues
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        List<int> numbers = new List<int>();
        private void btnAddClick(object sender, RoutedEventArgs e)
        {
            
            string input = this.txtBox1.Text;
            string[] result = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in result)
            {
                numbers.Add(int.Parse(s));
            }

            string showInput = string.Join(", ", numbers);

            txtBox2.Text = showInput;
            txtBox1.Text = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i<numbers.Count; i++)
            {
                for(int j=0; j<numbers.Count; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            string showInput = string.Join(", ", numbers);
            outputBox.Text = showInput;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for(int i=0; i<numbers.Count; i++)
            {
                for(int j=0; j<numbers.Count; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            string showInput = string.Join(", ", numbers);
            outputBox.Text = showInput;
        }
    }
}
