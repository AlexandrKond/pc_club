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

namespace CLUB_PC
{
    /// <summary>
    /// Логика взаимодействия для DataGrid.xaml
    /// </summary>
    public partial class DataGrid : Window
    {
        public DataGrid()
        {
            InitializeComponent();
            using (ApplicationContext context = new ApplicationContext())
            {
                DGridMovies.ItemsSource = context.Table.ToList();
            }
        }

        private void DGridTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                AddEditPage taskWindow = new AddEditPage((sender as Button).DataContext as Table);
                taskWindow.Show();
                this.Close();
            }
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddEditPage taskWindow = new AddEditPage(null);
            taskWindow.Show();
            this.Close();
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var TableDel = DGridMovies.SelectedItems.Cast<Table>().ToList();
                {
                    if (MessageBox.Show("Вы уверены, что хотите удалить?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        db.Table.RemoveRange(TableDel);
                        db.SaveChanges();
                        DGridMovies.ItemsSource = db.Table.ToList();
                    }
                }
            }
        }
    }
}
