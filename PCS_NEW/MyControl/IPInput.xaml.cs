using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PCS_NEW.MyControl
{
    /// <summary>
    /// IPInput.xaml 的交互逻辑
    /// </summary>
    public partial class IPInput : UserControl
    {
      
        public IPInput()
        {
            InitializeComponent();
        }

        public string AddressText
        {
            get
            {
                string ip = "";
                if (P1.Text == "")
                {
                    ip += "0";
                }
                else
                {
                    ip += P1.Text;
                }
                ip += ".";
                if (P2.Text == "")
                {
                    ip += "0";
                }
                else
                {
                    ip += P2.Text;
                }
                ip += ".";
                if (P3.Text == "")
                {
                    ip += "0";
                }
                else
                {
                    ip += P3.Text;
                }
                ip += ".";
                if (P4.Text == "")
                {
                    ip += "0";
                }
                else
                {
                    ip += P4.Text;
                }
                return ip;
            }
        }

        private void P1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 3)
            {
                P2.Focus();
            }
        }

        private void P2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 3)
            {
                P3.Focus();
            }
        }

        private void P3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.Length == 3)
            {
                P4.Focus();
            }
        }

        private void P4_TextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);

            if ((sender as TextBox).Text.Length == 3)
            {
                e.Handled = true;
            }
        }

        private void P1_TextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void P1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                P2.Focus();
                e.Handled = true;
            }

            if (e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                if (!string.IsNullOrEmpty(P1.Text))
                {
                    P2.Focus();
                    e.Handled = true;
                }
            }

            if (e.Key == Key.Right && (sender as TextBox).CaretIndex == (sender as TextBox).Text.Length)
            {
                P2.Focus();
                P2.CaretIndex = 0;
                e.Handled = true;
            }
        }

        private void P2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                P3.Focus();
                e.Handled = true;
            }

            if (e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                if (!string.IsNullOrEmpty(P2.Text))
                {
                    P3.Focus();
                    e.Handled = true;
                }
            }

            if (e.Key == Key.Back && P2.Text == "")
            {
                P1.Focus();
                e.Handled = true;
            }

            if (e.Key == Key.Right && (sender as TextBox).CaretIndex == (sender as TextBox).Text.Length)
            {
                P3.Focus();
                P3.CaretIndex = 0;
                e.Handled = true;
            }

            if (e.Key == Key.Left && (sender as TextBox).CaretIndex == 0)
            {
                P1.Focus();
                P1.CaretIndex = P1.Text.Length;
                e.Handled = true;
            }
        }

        private void P3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                P4.Focus();
                e.Handled = true;
            }

            if (e.Key == Key.OemPeriod || e.Key == Key.Decimal)
            {
                if (!string.IsNullOrEmpty(P3.Text))
                {
                    P4.Focus();
                    e.Handled = true;
                }
            }

            if (e.Key == Key.Back && P3.Text == "")
            {
                P2.Focus();
                e.Handled = true;
            }

            if (e.Key == Key.Right && (sender as TextBox).CaretIndex == (sender as TextBox).Text.Length)
            {
                P4.Focus();
                P4.CaretIndex = 0;
                e.Handled = true;
            }

            if (e.Key == Key.Left && (sender as TextBox).CaretIndex == 0)
            {
                P2.Focus();
                P2.CaretIndex = P2.Text.Length;
                e.Handled = true;
            }
        }

        private void P4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back && P4.Text == "")
            {
                P3.Focus();
            }

            if (e.Key == Key.Left && (sender as TextBox).CaretIndex == 0)
            {
                P3.Focus();
                P3.CaretIndex = P3.Text.Length;
                e.Handled = true;
            }
        }
    }
}
