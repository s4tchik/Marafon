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
    /// Логика взаимодействия для PageAddOrEdit.xaml
    /// </summary>
    public partial class PageAddOrEdit : Page
    {
        public PageAddOrEdit()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void btn_Reg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txbDisc_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txbName_GotFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
