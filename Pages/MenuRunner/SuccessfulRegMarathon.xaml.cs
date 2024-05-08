using Marafon.ClassHelper;
using Marafon.Pages.Runners;
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
    /// Логика взаимодействия для SuccessfulRegMarathon.xaml
    /// </summary>
    public partial class SuccessfulRegMarathon : Page
    {
        public SuccessfulRegMarathon()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageForRegMarathon());
        }
    }
}
