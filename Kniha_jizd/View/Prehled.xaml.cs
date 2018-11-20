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
using Kniha_jizd.Model;

namespace Kniha_jizd.View
{
    /// <summary>
    /// Interakční logika pro Prehled.xaml
    /// </summary>
    public partial class Prehled : Window
    {
        public Prehled()
        {
            InitializeComponent();
            NacistJizdy();
        }
        private void NacistJizdy()
        {
            DatovyGrid.Items.Clear();
            for (int i = 0; i < Master.Jizdy.Count; i++)
            {
                
                DatovyGrid.Items.Add(Master.Jizdy[i]);
            }
        }
        public class testovacitrida{
            public string datum { get; set; }
            public string identifikator { get; set; }
            public string kam { get; set; }
            public string odkud { get; set; }
            public string soukroma { get; set; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NacistJizdy();
        }
    }
}
