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

namespace Nullstellenberechnung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(txtbxa.Text);
            double b = Convert.ToDouble(txtbxb.Text);
            double c = Convert.ToDouble(txtbxc.Text);


            if (a==0.0)
            {
                MessageBox.Show("a muss verschieden von Null sein!");
            }
            else
            {
                double p, q, d;
                double x1, x2;
                p = b / a;
                q = c / a;
                d = Math.Pow(p / 2, 2) - q;
                if (d>0)
                {
                    x1 = -p / 2 + Math.Sqrt(d);
                    x2 = -p / 2 - Math.Sqrt(d);
                    txtbxas.Text = ("Es gibt zwei einfache reelle Nullstellen : x_1=" + x1 + "und x_2=" + x2 + ".");
                }
                else if (d==0.0)
                {
                    x1 = -p / 2;
                    txtbxas.Text = ("es gibt ene doppelte reelle Nullstelle: x_1=" + x1 + ".");

                }
                else
                {
                    txtbxas.Text = "es gibt keine reelle nullstelle.";
                }


            }
                
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
