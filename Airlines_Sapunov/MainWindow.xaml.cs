using Airlines_Sapunov.Pages;
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

namespace Airlines_Sapunov
{
    public partial class MainWindow : Window
    {
        public static MainWindow mainWindow;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
        }

        public enum pages
        {
            main,
            ticket
        }

        public void OpenPages(pages page) 
        {
            if (page == pages.main) 
            {
                frame.Navigate(new Main());
            }
            if (page == pages.ticket) 
            {
                frame.Navigate(new Ticket());
            }
        }
    }
}
