using _06_LibraryManagement_PRN221_Project.Models;
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

namespace _06_LibraryManagement_PRN221_Project
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private Account CurrentAccount { get; set; }

        public Home(Account account, Librarian librarian)
        {
            InitializeComponent();
            CurrentAccount = account;
            if (CurrentAccount.Role == 0) managerAccount.Visibility = Visibility.Visible;
            else if (CurrentAccount.Role == 1) managerAccount.Visibility = Visibility.Collapsed;
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Do you really want to logout?", "Logout", MessageBoxButton.YesNoCancel);
            if (result.Equals(MessageBoxResult.Yes))
            {
                this.Close();
                MainWindow main = new MainWindow();
                main.Show();
            }
        }
    }
}
