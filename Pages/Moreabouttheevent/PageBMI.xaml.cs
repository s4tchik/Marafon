﻿using Marafon.ClassHelper;
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
    /// Логика взаимодействия для PAgeBMI.xaml
    /// </summary>
    public partial class PAgeBMI : Page
    {
        public PAgeBMI()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void txbHeight_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void txbWeight_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void btnMale_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFemale_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
