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
    /// Логика взаимодействия для MainRunner.xaml
    /// </summary>
    public partial class MainRunner : Page
    {
        public MainRunner()
        {
            InitializeComponent();
        }

        private void btn_editprofile_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageProfileRunner());
        }

        private void btn_regmarathon_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageForRegMarathon());
        }

        private void btn_myresult_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageMyResults());
        }

        private void btn_sponsor_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageMySponsor());
        }

        private void btn_contact_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageContact());
        }
    }
}
