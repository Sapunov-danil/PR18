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

namespace Airlines_Sapunov.Pages
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.Close();
        }

        private void FindTickets(object sender, RoutedEventArgs e)
        {
            string fromText = from.Text.Trim().ToLower();
            string toText = to.Text.Trim().ToLower();

            var filteredTickets = MainWindow.mainWindow.ticketClasses
                .Where(t => t.from.ToLower() == fromText && t.to.ToLower() == toText)
                .ToList();

            var ticketPage = new Ticket();
            ticketPage.SetTickets(filteredTickets);
            MainWindow.mainWindow.frame.Navigate(ticketPage);
        }
    }
}
