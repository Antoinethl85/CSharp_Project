using System.Windows;

namespace CSharp_Project
{
    public partial class Admin_dashboard : Window
    {
        public Admin_dashboard()
        {
            InitializeComponent();
            
            dashboard_title.TextAlignment = TextAlignment.Center;
            dashboard_title.FontWeight = FontWeights.UltraBold;
            dashboard_title.FontSize = 20;
        }
        
        private void ButtonAdd(object sender, RoutedEventArgs routedEventArgs)
        {
            
        }
    }
}