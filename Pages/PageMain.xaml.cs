using Marafon.ClassHelper;
using Marafon.Pages.Runner;
using Marafon.Pages.Sponcor;
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

namespace Marafon.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void btn_runner_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new Reg());
        }

        private void btn_sponsor_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageSponsorARunner());
        }

        private void btn_about_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }
    }
}
