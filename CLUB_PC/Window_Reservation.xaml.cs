using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
    /// Логика взаимодействия для Window_Reservation.xaml
    /// </summary>
    public partial class Window_Reservation : Window
    {
        private Reservation reserv = new Reservation();
        public Window_Reservation(Reservation selectedReserv)
        {
            InitializeComponent();
            if (selectedReserv != null)
            {
                reserv = selectedReserv;
            }
            DataContext = reserv;
        }

        private void BtnReservation_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Reservation reservation  = DataContext as Reservation; //Переменная берет данные из таблицы Ticket
                if (reservation != null)
                {
                    db.Reservation.Update(reservation);
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    Check win = new Check();
                    win.Show();
                    this.Close();
                }
            }
        }

        private void BtnCancel3_Click(object sender, RoutedEventArgs e)
        {
            ListView win = new ListView(); //Переход назад
            win.Show();
            this.Close();
        }
    }
}
