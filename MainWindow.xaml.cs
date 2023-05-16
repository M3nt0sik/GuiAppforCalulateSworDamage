using ConsloleAppTOCalculationsDamageForOscar;
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

namespace GuiAppforCalulateSworDamage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {
        Random random = new Random();
        SwordDamage sword = new SwordDamage();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            sword.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
            bool chboxM = false;
            chboxM = (bool)ChBoxMagiczny.IsChecked.Value;
            bool chboxP = false;
            chboxP = (bool)ChBoxPlonacy.IsChecked.Value;
            sword.SetMagic(chboxM);
            sword.SetFlaming(chboxP);
            TBObrazenia.Text = "Rzut: " + sword.Roll.ToString() + " punkty obrazen: " + sword.Damage.ToString();

        }
    }
}
