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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void SumValues(object sender, RoutedEventArgs e)
        {
            double val1 = double.Parse(txtVal1.Text);
            double val2 = double.Parse(txtVal2.Text);
            double resultSum = val1 + val2;
            txtResult.Text = resultSum.ToString();

        }
    }
}
