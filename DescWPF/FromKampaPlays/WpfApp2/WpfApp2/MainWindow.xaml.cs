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

namespace WpfApp2
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
            //MessageBox.Show("hello we are here", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);

            //MessageBoxResult result = MessageBox.Show("Could not open file", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            MessageBoxResult result = MessageBox.Show("Do you agree?", "Agreement", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if(result == MessageBoxResult.Yes)
            {
                tbInfo.Text = "Agreed";
            }
            else
            {
                tbInfo.Text = "Not Agreed";
            }
        }
    }
}
