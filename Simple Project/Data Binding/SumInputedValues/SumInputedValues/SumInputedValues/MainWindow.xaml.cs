
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

namespace SumInputedValues
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

        private void btnAddClickAdd(object sender, RoutedEventArgs e)
        {
            string input = this.txtBox1.Text;

            lbBox2.Items.Add(int.Parse(input));



            //Do understand WPF Component

            ////string[] result = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            ////foreach (string s in result)
            ////{
            ////    numbers.Add(int.Parse(s));
            ////}

            ////string showInput = string.Join(", ", numbers);

            //////lbBox2.ItemsSource = showInput;
            //////txtBox1.Text = null;
            ////lbBox2.ItemsSource = null; // Reset binding
            ////lbBox2.ItemsSource = numbers;

            txtBox1.Clear();
        }

        private void btnAddClickSum(object sender, RoutedEventArgs e)
        {

        }

        List<int> numbers = new List<int>();
        private void btnAddClick(object sender, RoutedEventArgs e)
        {
            string input = this.txtBox1.Text;

            lbBox2.Items.Add(int.Parse(input));

            txtBox1.Clear();
        }

        private void btnAsc(object sender, RoutedEventArgs e)
        {
            List<int> numlst1 = new List<int>();
            foreach (int num in lbBox2.Items)
                numlst1.Add(num);

            for (int i = 0; i < numlst1.Count; i++)
            {
                for (int j = 0; j < numlst1.Count; j++)
                {
                    if (numlst1[i] < numlst1[j])
                    {
                        int temp = numlst1[j];
                        numlst1[j] = numlst1[i];
                        numlst1[i] = temp;
                    }
                }
            }
            lstbOutputBox.Items.Clear();
            foreach (var item in numlst1)
                lstbOutputBox.Items.Add(item);


        }

        private void btnDesc(object sender, RoutedEventArgs e)
        {
            List<int> numlst1 = new List<int>();
            foreach (int num in lbBox2.Items)
                numlst1.Add(num);


            for (int i = 0; i < numlst1.Count; i++)
            {
                for (int j = 0; j < numlst1.Count; j++)
                {
                    if (numlst1[i] > numlst1[j])
                    {
                        int temp = numlst1[j];
                        numlst1[j] = numlst1[i];
                        numlst1[i] = temp;
                    }
                }
            }
            lstbOutputBox.Items.Clear();
            foreach (var item in numlst1)
                lstbOutputBox.Items.Add(item);
        }

        private void btnSumAll(object sender, RoutedEventArgs e)
        {
            int sum = 0;

            foreach(int num in lbBox2.Items)
            {
                sum = sum + num;
            }

            txtbSumAll.Text = sum.ToString();
        }
    }
}