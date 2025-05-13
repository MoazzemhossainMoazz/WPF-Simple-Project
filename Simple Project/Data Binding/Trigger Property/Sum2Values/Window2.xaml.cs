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
using System.Windows.Shapes;

namespace Sum2Values
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private int value1 = 0;
        private int value2 = 0;
        public Window2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            value1 = 10;
            ResultTextBlock.Text = $"{value1}";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            value2 = 20;
            ResultTextBlock.Text = $"{value2}";
        }

        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            int result = value1 + value2;
            ResultTextBlock.Text = result.ToString();
        }
    }
}
