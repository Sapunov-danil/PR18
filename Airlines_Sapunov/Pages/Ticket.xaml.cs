using Airlines_Sapunov.Classes;
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
    public partial class Ticket : Page
    {
        public Ticket()
        {
            InitializeComponent();
        }

        public void SetTickets(List<TicketClass> tickets)
        {
            TicketsItemsControl.ItemsSource = tickets;
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow.mainWindow.OpenPages(MainWindow.pages.main);
        }
    }
}
