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
    /// Логика взаимодействия для PageManagingVolunteers.xaml
    /// </summary>
    public partial class PageManagingVolunteers : Page
    {
        public PageManagingVolunteers()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void btnAddInBd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOpenFolder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
