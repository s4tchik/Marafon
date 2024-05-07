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

namespace Marafon.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для PageUsersAdd.xaml
    /// </summary>
    public partial class PageUsersAdd : Page
    {
        public PageUsersAdd()
        {
            InitializeComponent();
        }

        private void txb_email_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_pass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_repeatpass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_name_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_surname_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
