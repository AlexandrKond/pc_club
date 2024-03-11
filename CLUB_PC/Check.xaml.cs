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
using Word = Microsoft.Office.Interop.Word;

namespace CLUB_PC
{
    /// <summary>
    /// Логика взаимодействия для Check.xaml
    /// </summary>
    public partial class Check : Window
    {
        public Check()
        {
            InitializeComponent();
            using (ApplicationContext db = new ApplicationContext())
            {
                var currentList = db.Reservation.ToList();
                LViewFilms.ItemsSource = currentList;
            }
        }

        private void BtnExport_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
