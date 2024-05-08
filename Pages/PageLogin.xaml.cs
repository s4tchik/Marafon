using Marafon.ClassHelper;
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
using Marafon.Pages.Runners;
using Marafon.Pages.Admin;
using Marafon.Pages.Coordinator;
using Marafon.Pages.MenuRunner;

namespace Marafon.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btn_auth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = OdbConectHelper.dbobj.Users.FirstOrDefault(
                    x => x.Email == txb_email.Text && x.Password == txb_password.Text
                    );
                if (userObj == null)
                {
                    /// добавть больше конкретики, тоесть если введен неверный пароль то так и пишет
                    MessageBox.Show("Такой пользователь отсутсвует в приложения",
                        "Уведомление",
                         MessageBoxButton.OK,
                         MessageBoxImage.Warning);
                }
                else
                {
                    switch (userObj.RoleId)
                    {
                        case "R":
                            FrameApp.frmObj.Navigate(new MainRunner());
                            break;
                        case "C":
                            FrameApp.frmObj.Navigate(new MainPageCoordinator());
                            break;
                        case "A":
                            FrameApp.frmObj.Navigate(new MainPageAdmin());
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбор в работе приложения", "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
            //FrameApp.frmObj.Navigate(new Reg());
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void txb_email_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
