using Project_Library_Management_FA23_BL5.Models;
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
using System.Windows.Xps;

namespace Project_Library_Management_FA23_BL5
{
    /// <summary>
    /// Interaction logic for ReaderManager.xaml
    /// </summary>
    public partial class ReaderManager : Page
    {
        public LibraryManagementContext context;
        public ReaderManager()
        {
            context = new LibraryManagementContext();
            InitializeComponent();
            Load();
        }

        public Reader GetReader()
        {
            Reader reader = null;
            try
            {

                reader = new Reader()
                {
                    //Id = int.Parse(txtEmployeeID.Text),
                    CardNumber = int.Parse(txtCardNumber.Text)

                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return reader;
        }
        //
        //public static List<Reader> GetReaders()
        //{
        //    using var context = new LibraryManagementContext();
        //    return context.Readers.ToList();
        //}

        //public static Reader? GetReader(int readerCardId)
        //{
        //    using var context = new LibraryManagementContext();
        //    return context.Readers.FirstOrDefault(x => x.CardNumber == readerCardId);
        //}

        //public static Reader? GetReader(string fullname)
        //{
        //    using var context = new LibraryManagementContext();
        //    return context.Readers.FirstOrDefault(x => x.FullName.Contains(fullname, StringComparison.OrdinalIgnoreCase));
        //}

        //public static void AddReader(Reader data)
        //{
        //    using var context = new LibraryManagementContext();
        //    context.Readers.Add(data);
        //    context.SaveChanges();
        //}

        //public static void UpdateReader(Reader data)
        //{
        //    using var context = new LibraryManagementContext();
        //    context.Readers.Update(data);
        //    context.SaveChanges();
        //}

        //public static void DeleteReader(Reader data)
        //{
        //    using var context = new LibraryManagementContext();
        //    context.Readers.Remove(data);
        //    context.SaveChanges();
        //}
        ////
        public void Load()
        {
            try
            {
                using (var context = new LibraryManagementContext())
                {
                    var data = context.Readers.ToList();
                    listReader.ItemsSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Refresh_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
