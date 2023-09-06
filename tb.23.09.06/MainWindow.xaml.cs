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

namespace tb._23._09._06
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

        public void kiszamol()
        { double eredmeny = 0;
            double mennyiseg = Convert.ToDouble(adatmennyisegtbox.Text);
            double sebesseg = Convert.ToDouble(slValue.Value);
        if (sebessegdropdown.Text == "MB/s" && adatdropdown.Text == "MB") { 
             eredmeny = mennyiseg/ sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "KB/s" && adatdropdown.Text == "KB")
            {
                 eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "GB/s" && adatdropdown.Text == "GB")
            {
                 eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }


            if (sebessegdropdown.Text == "MB/s" && adatdropdown.Text == "KB")
            {
                mennyiseg = mennyiseg * 1000;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "MB/s" && adatdropdown.Text == "GB")
            {
                mennyiseg = mennyiseg * 1000;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "MB/s" && adatdropdown.Text == "TB")
            {
                mennyiseg = mennyiseg * 1000000;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }


            if (sebessegdropdown.Text == "KB/s" && adatdropdown.Text == "GB")
            {
                mennyiseg = mennyiseg * 1000;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "KB/s" && adatdropdown.Text == "MB")
            {
                mennyiseg = mennyiseg * 0.001;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "KB/s" && adatdropdown.Text == "TB")
            {
                mennyiseg = mennyiseg * 1000000000;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }

            if (sebessegdropdown.Text == "GB/s" && adatdropdown.Text == "TB")
            {
                mennyiseg = mennyiseg * 1000;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "GB/s" && adatdropdown.Text == "MB")
            {
                mennyiseg = mennyiseg * 0.001;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
            if (sebessegdropdown.Text == "GB/s" && adatdropdown.Text == "KB")
            {
                mennyiseg = mennyiseg * 0.000001;
                eredmeny = mennyiseg / sebesseg;
                eredmenytbox.Text = Convert.ToString(Math.Round(eredmeny));
            }
        }
        private void atvaltott()
        {
            double eredmeny = Convert.ToDouble(eredmenytbox.Text);
            double orak = Math.Floor(eredmeny / 3600);
            eredmeny %= 3600;
            double percek = Math.Floor(eredmeny / 60);
            double maradekMasodpercek = eredmeny % 60;
            veglegestbox.Text = ($"{orak} óra, {percek} perc {maradekMasodpercek} masodperc");
        }
        private void kiszamolGomb_Click(object sender, RoutedEventArgs e)
        {
            kiszamol();
            atvaltott();
        }
    }
}
