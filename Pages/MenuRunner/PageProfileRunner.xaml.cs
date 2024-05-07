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

namespace Marafon.Pages.MenuRunner
{
    /// <summary>
    /// Логика взаимодействия для PageProfileRunner.xaml
    /// </summary>
    public partial class PageProfileRunner : Page
    {
        public PageProfileRunner()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new MainRunner());
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void btn_source_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txb_name_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_surname_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_pathphoto_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_pass_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txb_repeatpass_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
