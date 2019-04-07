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

namespace CurrencyMidterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyRepo currencyRepo;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MakeChangeBTN_Click(object sender, RoutedEventArgs e)
        {
            ChangeListTB.Clear();

            currencyRepo = new CurrencyRepo();

            double amount = Convert.ToDouble(AmountTB.Text);

            currencyRepo.CreateChange(amount);
            
            for(int i = 0; i < currencyRepo.Coins.Count; i++)
            {
                ChangeListTB.Text += currencyRepo.Coins[i].name + "\n";
            }

        }

        private void LoadWindowBTN_Click(object sender, RoutedEventArgs e)
        {
            AddCoinWindow w2 = new AddCoinWindow();
            w2.Show();
            this.Close();
        }
    }
}
