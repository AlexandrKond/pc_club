using System;
using System.Collections.Generic;
using System.Data.Common;
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


namespace CLUB_PC
{
    /// <summary>
    /// Логика взаимодействия для ListView.xaml
    /// </summary>
    public partial class ListView : Window
    {
        public ListView()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentList = db.Table.ToList();
                LView.ItemsSource = currentList;
            }
        }

        private void TBox_Search(object sender, TextChangedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentHall = db.Table.ToList();
                currentHall = currentHall.Where(p => p.type_hall.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                LView.ItemsSource = currentHall.OrderBy(p => p.id_table).ToList();

            }
        }
        private void BtnReservation_Click(object sender, RoutedEventArgs e)
        {
            Window_Reservation task = new Window_Reservation(null);
            task.Show();
            this.Close();
        }
        
        private void BtnFiltr_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentHall = db.Table.ToList();
                currentHall = currentHall.Where(p => p.type_hall.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                LView.ItemsSource = currentHall.OrderBy(p => p.price).ToList();
            }
        }

        private void BtnFiltr2_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentHall = db.Table.ToList();
                currentHall = currentHall.Where(p => p.type_hall.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
                LView.ItemsSource = currentHall.OrderByDescending(p => p.price).ToList();
            }
        }
    }
}
