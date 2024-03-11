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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void BtnCancel1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow taskwindow = new MainWindow();
            taskwindow.Show();
            this.Close();
        }

        private void BtnRegistr_Click(object sender, RoutedEventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                User user = new User();
                user.login = Login2.Text;
                user.password = Password2.Text;
                user.type_user = role_txt.Text;
                db.Add(user);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    MainWindow task = new MainWindow();
                    task.Show();
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
