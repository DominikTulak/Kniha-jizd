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

namespace Kniha_jizd.View
{
    /// <summary>
    /// Interakční logika pro Odebrat.xaml
    /// </summary>
    public partial class Odebrat : Window
    {
        public Odebrat()
        {
            InitializeComponent();
        }

        private void btn_storno_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_odebrat_Click(object sender, RoutedEventArgs e)
        {
            try {
                Model.Master.Odebrat_jizdu(Convert.ToInt16(cislo.Text));
                if(Convert.ToInt16(cislo.Text) > Model.Master.pocet_jizd)
                {
                    MessageBox.Show("Neplatné číslo!");
                }
            }
            catch
            {
                MessageBox.Show("Neplatné číslo!");
            }
        }
    }
}
