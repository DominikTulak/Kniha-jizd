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
using Kniha_jizd.Model;

namespace Kniha_jizd
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Testovací jízda
            
            
        }

        private void btn_PrehledJizd_Click(object sender, RoutedEventArgs e)
        {
            View.Prehled prehled = new View.Prehled();
            prehled.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            View.Window1 Pridat = new View.Window1();
            Pridat.Show();
        }

        private void btn_OdebratJizdu_Click(object sender, RoutedEventArgs e)
        {
            View.Odebrat odebrat = new View.Odebrat();
            odebrat.Show();
        }
    }
}
