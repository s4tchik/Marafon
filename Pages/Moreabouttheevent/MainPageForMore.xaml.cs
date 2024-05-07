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

namespace Marafon.Pages.Moreabouttheevent
{
    /// <summary>
    /// Логика взаимодействия для MainPageForMore.xaml
    /// </summary>
    public partial class MainPageForMore : Page
    {
        public MainPageForMore()
        {
            InitializeComponent();
        }

        private void btn_lastresult_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_marathon_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new HowLongs());
        }

        private void btn_statsmarathon_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_listfund_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageList());
        }

        private void btn_bmicalc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_bmrcalc_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
