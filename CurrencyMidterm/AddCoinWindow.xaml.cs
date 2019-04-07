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

namespace CurrencyMidterm
{
    /// <summary>
    /// Interaction logic for AddCoinWindow.xaml
    /// </summary>
    public partial class AddCoinWindow : Window
    {
        CurrencyRepo currencyRepo = new CurrencyRepo();
        public AddCoinWindow()
        {
            InitializeComponent();
        }

        private void LoadWindowBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w1 = new MainWindow();
            w1.Show();
            this.Close();
        }

        private void AddCoinBTN_Click(object sender, RoutedEventArgs e)
        {
            currencyRepo.AddCoin(FindTheRightCoin(CoinChoiceCMB.Text));

            RepoValueTB.Text = currencyRepo.TotalValue().ToString();
        }

        private ICoin FindTheRightCoin(string type)
        {
            ICoin coin = null;

            switch(type)
            {
                case "Penny":
                    USCoins.Penny penny = new USCoins.Penny();
                    coin = penny;
                    break;
                case "Nickel":
                    USCoins.Nickel nickel = new USCoins.Nickel();
                    coin = nickel;
                    break;
                case "Dime":
                    USCoins.Dime dime = new USCoins.Dime();
                    coin = dime;
                    break;
                case "Quarter":
                    USCoins.Quarter quarter = new USCoins.Quarter();
                    coin = quarter;
                    break;
                case "Dollar Coin":
                    USCoins.DollarCoin dollarCoin = new USCoins.DollarCoin();
                    coin = dollarCoin;
                    break;
            }

            return coin;
        }
    }
}
