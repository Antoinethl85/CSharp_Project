using System.Windows;

namespace CSharp_Project
{
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }
        
        private void ButtonGoDashboard(object sender, RoutedEventArgs routedEventArgs)
        {
            Admin_dashboard adPage = new Admin_dashboard();
            adPage.Owner = this;
            adPage.Show();
        }
    }
}