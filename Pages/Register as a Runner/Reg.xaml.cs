using Marafon.ClassHelper;
using Marafon.Pages.MenuRunner;
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

namespace Marafon.Pages.Runner
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Page
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void btn_newrunner_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new NewRunner());
        }

        private void btn_oldrunner_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new MainRunner());
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }
    }
}
