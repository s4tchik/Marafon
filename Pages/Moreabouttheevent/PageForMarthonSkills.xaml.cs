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
    /// Логика взаимодействия для PageForMarthonSkills.xaml
    /// </summary>
    public partial class PageForMarthonSkills : Page
    {
        public PageForMarthonSkills()
        {
            InitializeComponent();
        }

        private void btnMap_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageWithMap());
        }
    }
}
