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

namespace Lab4WpfApp
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

        private void РассчитатьUSD_Click(object sender, RoutedEventArgs e)
        {
            double RateDollar = Convert.ToDouble(rateDollar.Text);
            double SumDollar = Convert.ToDouble(sumDollar.Text);
            double ResDollar = RateDollar * SumDollar;
            resDollar.Text = ResDollar.ToString();
        }

        private void РассчитатьEUR_Click(object sender, RoutedEventArgs e)
        {
            double RateEur = Convert.ToDouble(rateEur.Text);
            double SumEur = Convert.ToDouble(sumEur.Text);
            double ResEur = RateEur * SumEur;
            resEur.Text = ResEur.ToString();
        }

        private void РассчитатьLIR_Click(object sender, RoutedEventArgs e)
        {
            double RateLir = Convert.ToDouble(rateLir.Text);
            double SumLir = Convert.ToDouble(sumLir.Text);
            double ResLir = RateLir * SumLir;
            resLir.Text = ResLir.ToString();
        }

        private void РассчитатьGoldTeeth_Click(object sender, RoutedEventArgs e)
        {
            double RateGol = Convert.ToDouble(rateGol.Text);
            double SumGol = Convert.ToDouble(sumGol.Text);
            double ResGol = RateGol * SumGol;
            resGol.Text = ResGol.ToString();
        }

        private void РассчитатьInch_Click(object sender, RoutedEventArgs e)
        {
            double SumInch = Convert.ToDouble(sumInch.Text);
            double ResInch =  0.0254 * SumInch;
            resInch.Text = ResInch.ToString();
        }

        private void РассчитатьFoot_Click(object sender, RoutedEventArgs e)
        {
            double SumFoot = Convert.ToDouble(sumFoot.Text);
            double ResFoot = 0.3048 * SumFoot;
            resFoot.Text = ResFoot.ToString();
        }

        private void РассчитатьMiles_Click(object sender, RoutedEventArgs e)
        {
            double SumMil = Convert.ToDouble(sumMil.Text);
            double ResMil = 1609.34 * SumMil;
            resMil.Text = ResMil.ToString();
        }

        private void РассчитатьVersts_Click(object sender, RoutedEventArgs e)
        {
            double SumVer = Convert.ToDouble(sumVer.Text);
            double ResVer = 1066.8 * SumVer;
            resVer.Text = ResVer.ToString();
        }
    }
}
