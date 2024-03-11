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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Window


    {
        private Table table = new Table();
        public AddEditPage(Table selectedTable)
        {
            InitializeComponent();

            if (selectedTable != null)
            {
                table = selectedTable;
            }
            DataContext = table;
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Table table = DataContext as Table;
                if (table != null)
                {
                    db.Table.Update(table);
                    db.SaveChanges();
                    MessageBox.Show("Сохранено");
                    DataGrid win = new DataGrid();
                    win.Show();
                    this.Close();
                }
            }
        }
        private void BtnCancel2_Click(object sender, RoutedEventArgs e)
        {
            DataGrid task = new DataGrid();
            task.Show();
            this.Close();
        }
    }
}
