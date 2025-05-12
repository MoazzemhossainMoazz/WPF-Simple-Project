using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace DemoCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int result = 0;
        private int? input = null;
        private bool initial = true;

       // private Dictionary<string, string> operators = new ();
        


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn && btn.Content == "0")
            {
                if (!initial && input is null) input = 0;
                else
                {
                    result = 0;
                    initial = false;
                }
                return;
            }

            else if (sender is Button btn1 && btn1.Content == "1")
            {
                if (!initial && input is null) input = 1;
                else
                {
                    result = 1;
                    initial = false;
                }
                return;
            }
            else if (sender is Button btn2 && btn2.Content == "2")
            {
                if (!initial && input is null) input = 2;
                else
                {
                    result = 2;
                    initial = false;

                }
                return;
            }
            else if (sender is Button btn3 && btn3.Content == "3")
            {
                if (!initial && input is null) input = 3;
                else
                {
                    result = 3;
                    initial = false;

                }
                return;
            }
            else if (sender is Button btn4 && btn4.Content == "4")
            {
                if (!initial && input is null) input = 4;
                else
                {
                    result = 4;
                    initial = false;

                }
                return;
            }
            else if (sender is Button btn5 && btn5.Content == "5")
            {
                if (!initial && input is null) input = 5;
                else
                {
                    result = 5;
                    initial = false;

                }
                return;
            }
            else if (sender is Button btn6 && btn6.Content == "6")
            {
                if (!initial && input is null) input = 6;
                else
                {
                    result = 6;
                    initial = false;

                }
                return;
            }
            else if (sender is Button btn7 && btn7.Content == "7")
            {
                if (!initial && input is null) input = 7;
                else
                {
                    result = 7;
                    initial = false;

                }
                return;
            }
            else if (sender is Button btn8 && btn8.Content == "8")
            {
                if (!initial) input = 8;
                else
                {
                    result = 8;
                    initial = false;

                }
                return;
            }
            else if (sender is Button btn9 && btn9.Content == "9")
            {
                if (!initial) input = 9;
                else
                {
                    result = 9;
                    initial = false;

                }
                return;
            }


        }

        private void PlusBtn_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonACOnClick(object sender, RoutedEventArgs e)
        {

        }


        private void ButtonCOnClick(object sender, RoutedEventArgs e)
        {

        }



    }
}
