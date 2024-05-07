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
    /// Логика взаимодействия для PageMyResults.xaml
    /// </summary>
    public partial class PageMyResults : Page
    {
        public PageMyResults()
        {
            InitializeComponent();
        }

        private void btn_showallresults_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PreviousResult());
        }
    }
}
