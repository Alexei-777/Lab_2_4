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

namespace Lab_2_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate1.Text);
            double sumDollar = Convert.ToDouble(sum1.Text);
            double resDouble = rateDollar * sumDollar;
            resSum1.Text = resDouble.ToString();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate2.Text);
            double sumDollar = Convert.ToDouble(sum2.Text);
            double resDouble = rateDollar * sumDollar;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate3.Text);
            double sumDollar = Convert.ToDouble(sum3.Text);
            double resDouble = rateDollar * sumDollar;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            cm.Text = (Convert.ToDouble(mm.Text) * 0.1).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            m.Text = (Convert.ToDouble(mm1.Text) * 0.001).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            km.Text = (Convert.ToDouble(mm2.Text) * 0.000001).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            kg.Text = (Convert.ToDouble(gr.Text) * 0.001).ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            sc.Text = (Convert.ToDouble(gr1.Text) * 0.00001).ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tn.Text = (Convert.ToDouble(gr2.Text) * 0.000001).ToString();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            min.Text = (Convert.ToDouble(sec.Text) * 0.017).ToString();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            ch.Text = (Convert.ToDouble(sec1.Text) * 0.00028).ToString();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            dn.Text = (Convert.ToDouble(sec2.Text) * 0.000012).ToString();
        }
    }
}
