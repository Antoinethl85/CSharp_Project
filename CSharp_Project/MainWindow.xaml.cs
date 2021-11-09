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
using Newtonsoft.Json;

namespace CSharp_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            MainGrid.Background = new SolidColorBrush(Color.FromArgb(255, 179, 182, 181));
            TextBlock.FontSize = 30;
            TextBlock.TextAlignment = TextAlignment.Center;
            TextBlock.FontWeight = FontWeights.UltraBold;
        }
        
        private void ButtonGoAdmin(object sender, RoutedEventArgs routedEventArgs)
        {
            Admin aPage = new Admin();
            aPage.Owner = this;
            aPage.Show();
        }
        
        private void ButtonGoClient(object sender, RoutedEventArgs routedEventArgs)
        {
            Client cWin = new Client();
            cWin.Owner = this;
            cWin.Show();

        }
    }

    class Components
    {
        public static bool Import()
        {
            try
            {
                String URLString = "https://v6.exchangerate-api.com/v6/397792849ebfabdf13bee31f/latest/USD";
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString(URLString);
                    //API_Obj Test = JsonConvert.DeserializeObject(json);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}